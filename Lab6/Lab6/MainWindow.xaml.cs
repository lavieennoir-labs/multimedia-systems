using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        List<SphereModel3D> spheres = new List<SphereModel3D>();
        SphereModel3D SelectedSphere = null;

        public MainWindow()
        {
            InitializeComponent();
            SphereModel3D center = new SphereModel3D { Radius = 0.5 };
            center.UpdateSphereMesh();
            meshGroup.Children.Add(center.Geometry);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NewFigure(object sender, RoutedEventArgs e)
        {

            var sphere = new SphereModel3D
            {
                Radius = random.NextDouble() * 3 + 0.1,
                Center = new Point3D(0, 0, 0),
                Material = new Color { R = (byte)random.Next(0, 256), G = (byte)random.Next(0, 256), B = (byte)random.Next(0, 256), A = random.Next(0,2) == 0 ? (byte)255 : (byte)random.Next(64, 256)  },
                Orbita = random.NextDouble() * 7 + 2,
                Angle = random.Next(0, 360),
                AngleSpeed = random.NextDouble() * 3 + 0.1
            };
            sphere.Geometry.Transform = new Transform3DGroup
            {
                Children = new Transform3DCollection
                {
                    new TranslateTransform3D(sphere.Orbita, 0, 0),
                    new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0,0,1),sphere.Angle))
                }
            };
            sphere.Timer.Enabled = true;
            sphere.UpdateSphereMesh();
            spheres.Add(sphere);
            meshGroup.Children.Add(sphere.Geometry);
        }

        private void Viewport3D_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            Point location = Mouse.GetPosition(viewport);
            HitTestResult hit = VisualTreeHelper.HitTest(viewport, location);
            var meshHit = hit as RayMeshGeometry3DHitTestResult;
            var sphere = spheres.Where(s => s.Geometry.Equals(meshHit.ModelHit)).FirstOrDefault();
            if (sphere == null) // if Model3D object weren't touched 
                e.Handled = true;
            else
                SelectedSphere = sphere;
        }

        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            SelectedSphere.Material = new Color { R = (byte)random.Next(0, 256), G = (byte)random.Next(0, 256), B = (byte)random.Next(0, 256), A = random.Next(0, 2) == 0 ? (byte)255 : (byte)random.Next(64, 256) };
        }

        private void ChangeSize(object sender, RoutedEventArgs e)
        {
            SelectedSphere.Radius = random.NextDouble() * 3 + 0.1;
            SelectedSphere.UpdateSphereMesh();
        }

        private void Stop(object sender, RoutedEventArgs e)
        {
            SelectedSphere.Timer.Enabled = false;
        }

        private void Go(object sender, RoutedEventArgs e)
        {
            SelectedSphere.Timer.Enabled = true;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            SelectedSphere.Timer.Enabled = false;
            meshGroup.Children.Remove(SelectedSphere.Geometry);
            spheres.Remove(SelectedSphere);
        }
    }
}
