using System;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

//C:\Polina\C#\Light\bin\Debug\Light.exe

namespace Light
{
    public partial class SecondWindow : Window
    {
        private Assembly currentAssembly;
        private object instance;

        public SecondWindow()
        {
            InitializeComponent();
        }

        private void LoadAssemblyButton_Click(object sender, RoutedEventArgs e)
        {
            string path = AssemblyPathTextBox.Text;
            currentAssembly = Assembly.LoadFrom(path);
            List<Type> lightDevices = currentAssembly.GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ILightingDevice)))
                .ToList();

            ClassListBox.Items.Clear();
            foreach (Type type in lightDevices)
            {
                ClassListBox.Items.Add(type.FullName);
            }
        }

        private void ClassListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedClass = ClassListBox.SelectedItem as string;
            Type type = currentAssembly.GetType(selectedClass);
            MethodInfo[] methods = type.GetMethods();
            instance = Activator.CreateInstance(type);

            MethodsListBox.Items.Clear();
            foreach (MethodInfo method in methods)
            {
                MethodsListBox.Items.Add(method.Name);
            }
        }

        private void ExecuteMethodButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedClass = ClassListBox.SelectedItem as string;
            Type type = currentAssembly.GetType(selectedClass);
            MethodInfo method = type.GetMethod(MethodsListBox.SelectedItem as string);

            if (method.GetParameters().Length == 0)
            {
                object result = method.Invoke(instance, null);
                if (result != null)
                    ValueTextBox.Text = result.ToString();
            }
            else
            {
                ParameterInfo[] parameters = method.GetParameters();

                object[] methodParams = new object[parameters.Length];

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].ParameterType == typeof(int))
                    {
                        methodParams[i] = Convert.ToInt32(ParameterValueTextBox.Text);
                    }
                    else if (parameters[i].ParameterType == typeof(bool))
                    {
                        methodParams[i] = 
                            ParameterValueTextBox.Text == "1" | 
                            string.Equals(ParameterValueTextBox.Text, "true", StringComparison.OrdinalIgnoreCase);
                    }
                    else if (parameters[i].ParameterType == typeof(double))
                    {
                        methodParams[i] = Convert.ToDouble(ParameterValueTextBox.Text);
                    }
                }

                method.Invoke(instance, methodParams);
            }
        }

        private void MethodsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ParameterValueTextBox.Clear();
            ValueTextBox.Clear();
        }
    }
}
