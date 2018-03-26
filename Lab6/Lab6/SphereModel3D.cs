using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Lab6
{
    public class SphereModel3D
    {
        public Timer Timer { get; set; }

        private MeshGeometry3D mesh;
        public MeshGeometry3D Mesh
        {
            get { return mesh; }
            set
            {
                if (mesh == value)
                    return;
                mesh = value;
                OnPropertyChanged("Mesh");
                OnPropertyChanged("Geometry");
            }
        }

        private Point3D center;
        public Point3D Center
        {
            get { return center; }
            set
            {
                if (center == value)
                    return;
                center = value;
                OnPropertyChanged("Center");
            }
        }

        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius == value)
                    return;
                radius = value;
                OnPropertyChanged("Radius");
            }
        }

        private int vericalVertexCount;
        public int VericalVertexCount
        {
            get { return vericalVertexCount; }
            set
            {
                if (vericalVertexCount == value)
                    return;
                vericalVertexCount = value;
                OnPropertyChanged("VericalVertexCount");
            }
        }

        private int radialVertexCount;
        public int RadialVertexCount
        {
            get { return radialVertexCount; }
            set
            {
                if (radialVertexCount == value)
                    return;
                radialVertexCount = value;
                OnPropertyChanged("RadialVertexCount");
            }
        }

        private Color material;
        public Color Material
        {
            get { return material; }
            set
            {
                if (material == value)
                    return;
                material = value;
                try
                {
                    App.Current.Dispatcher.Invoke(() => (((geometry.Material as DiffuseMaterial).
                        Brush) as SolidColorBrush).
                            Color = material);
                }
                catch { }
                OnPropertyChanged("Material");
                OnPropertyChanged("Geometry");
            }
        }
        private double orbita;
        public double Orbita
        {
            get { return orbita; }
            set
            {
                if (orbita == value)
                    return;
                orbita = value;
                OnPropertyChanged("Orbita");
            }
        }

        private double angle;
        public double Angle
        {
            get { return angle; }
            set
            {
                if (angle == value)
                    return;
                angle = value;
                if (angle >= 360)
                    angle %= 360;
                try
                {
                    App.Current.Dispatcher.Invoke(() => ((((geometry.Transform as Transform3DGroup).
                        Children[1]) as RotateTransform3D).
                            Rotation as AxisAngleRotation3D).Angle = angle);
                }
                catch { }
                OnPropertyChanged("Angle");
                OnPropertyChanged("Geometry");
            }
        }

        private double angleSpeed;
        public double AngleSpeed
        {
            get { return angleSpeed; }
            set
            {
                if (angleSpeed == value)
                    return;
                angleSpeed = value;
                OnPropertyChanged("AngleSpeed");
            }
        }

        private Dictionary<Point3D, int> PointDictionary =
            new Dictionary<Point3D, int>();


        public SphereModel3D()
        {
            Timer = new Timer(16);
            Timer.Elapsed += (obj, e) => Angle += AngleSpeed;
            Timer.Enabled = false;

            mesh = new MeshGeometry3D();
            material = Colors.Red;
            geometry = new GeometryModel3D(this.mesh, new DiffuseMaterial(new SolidColorBrush(this.material)));
            geometry.Transform = new Transform3DGroup
            {
                Children = new Transform3DCollection
                { 
                    new TranslateTransform3D(Orbita, 0, 0),
                    new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0,0,1), Angle))
                }
            };
            center = new Point3D(0, 0, 0);
            radius = 1;
            vericalVertexCount = 30;
            radialVertexCount = 30;
            Angle = 0;
            AngleSpeed = 1;
            orbita = 1;
            UpdateSphereMesh();
        }


        public void UpdateSphereMesh()
        {
            PointDictionary.Clear();
            Mesh = new MeshGeometry3D();

            double phi0, theta0;
            double dphi = Math.PI / vericalVertexCount;
            double dtheta = 2 * Math.PI / radialVertexCount;

            phi0 = 0;
            double y0 = radius * Math.Cos(phi0);
            double r0 = radius * Math.Sin(phi0);
            for (int i = 0; i < vericalVertexCount; i++)
            {
                double phi1 = phi0 + dphi;
                double y1 = radius * Math.Cos(phi1);
                double r1 = radius * Math.Sin(phi1);

                // Point ptAB has phi value A and theta value B.
                // For example, pt01 has phi = phi0 and theta = theta1.
                // Find the points with theta = theta0.
                theta0 = 0;
                Point3D pt00 = new Point3D(
                    center.X + r0 * Math.Cos(theta0),
                    center.Y + y0,
                    center.Z + r0 * Math.Sin(theta0));
                Point3D pt10 = new Point3D(
                    center.X + r1 * Math.Cos(theta0),
                    center.Y + y1,
                    center.Z + r1 * Math.Sin(theta0));
                for (int j = 0; j < radialVertexCount; j++)
                {
                    // Find the points with theta = theta1.
                    double theta1 = theta0 + dtheta;
                    Point3D pt01 = new Point3D(
                        center.X + r0 * Math.Cos(theta1),
                        center.Y + y0,
                        center.Z + r0 * Math.Sin(theta1));
                    Point3D pt11 = new Point3D(
                        center.X + r1 * Math.Cos(theta1),
                        center.Y + y1,
                        center.Z + r1 * Math.Sin(theta1));

                    // Create the triangles.
                    AddTriangle(mesh, pt00, pt11, pt10);
                    AddTriangle(mesh, pt00, pt01, pt11);

                    // Move to the next value of theta.
                    theta0 = theta1;
                    pt00 = pt01;
                    pt10 = pt11;
                }

                // Move to the next value of phi.
                phi0 = phi1;
                y0 = y1;
                r0 = r1;
            }
            geometry.Geometry = Mesh;
            OnPropertyChanged("Mesh");
            OnPropertyChanged("Geometry");
        }

        private void AddTriangle(MeshGeometry3D mesh,
            Point3D point1, Point3D point2, Point3D point3)
        {
            // Get the points' indices.
            int index1 = AddPoint(mesh.Positions, point1);
            int index2 = AddPoint(mesh.Positions, point2);
            int index3 = AddPoint(mesh.Positions, point3);

            // Create the triangle.
            mesh.TriangleIndices.Add(index1);
            mesh.TriangleIndices.Add(index2);
            mesh.TriangleIndices.Add(index3);
        }

        private int AddPoint(Point3DCollection points, Point3D point)
        {
            // If the point is in the point dictionary,
            // return its saved index.
            if (PointDictionary.ContainsKey(point))
                return PointDictionary[point];

            // We didn't find the point. Create it.
            points.Add(point);
            PointDictionary.Add(point, points.Count - 1);
            return points.Count - 1;
        }

        private GeometryModel3D geometry;
        public GeometryModel3D Geometry
        {
            get
            {
                if (geometry == null)
                {
                    geometry = new GeometryModel3D(this.mesh, new DiffuseMaterial(new SolidColorBrush(this.material)));
                    geometry.Transform = new Transform3DGroup
                    {
                        Children = new Transform3DCollection
                        {
                            new TranslateTransform3D(Orbita, 0, 0),
                            new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0,0,1), Angle))
                        }
                    };
                }
                return geometry;
            }
            set
            {
                if (geometry == value)
                    return;
                geometry = value;
                OnPropertyChanged("Geometry");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
