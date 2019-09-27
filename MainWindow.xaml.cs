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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Microarchitecture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Quantitative_Design_and_Analysis_Click(object sender, RoutedEventArgs e)
        {
            Quantitative_Design_and_Analysis Quantitative_Design_and_AnalysisObject = new Quantitative_Design_and_Analysis();
            Quantitative_Design_and_AnalysisObject.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Parallelism ParallelismObject = new Parallelism();
            ParallelismObject.Show();
        }

        private void PipelineConcepts_Click(object sender, RoutedEventArgs e)
        {
            PipelineConcepts PipelineConceptsObject = new PipelineConcepts();
            PipelineConceptsObject.Show();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
