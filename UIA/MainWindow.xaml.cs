using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Automation;
using System.IO;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Security.Policy;
using System.Windows.Forms;
using Path = System.IO.Path;
namespace UIA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string redDir = @"E:\photograph\模型库\红发";
        private string pinkDir = @"E:\photograph\模型库\粉发";
        private string greenDir = @"E:\photograph\模型库\绿发";
        private string blueDir = @"E:\photograph\模型库\蓝发";
        private string yellowDir = @"E:\photograph\模型库\金发";
        private string orangeDir = @"E:\photograph\模型库\橙发";
        private string blackDir = @"E:\photograph\模型库\黑发";
        private string whiteDir = @"E:\photograph\模型库\银发";
        private string colorDir = @"E:\photograph\模型库\彩发";
        private string darkDir = @"E:\photograph\模型库\暗色";
        private string cyanDir = @"E:\photograph\模型库\靛青色";
        private string delDir = @"E:\photograph\TEMP";
        private string purpleDir = @"E:\photograph\模型库\紫发";
        private string brownDir = @"E:\photograph\模型库\褐发";
        private string womenDir = @"E:\photograph\pic";
        private string multileDir = @"E:\photograph\多人";
        private string materDir = @"E:\photograph\模型库";
        //string sourceDir = @"E:\photograph\TODO";
        private string backgroundDir = @"E:\photograph\background\青空";
        static AutomationElement ImageGlass = GETWindow.FindConditions();
        string sourceDir = GETWindow.GetNowDir(ImageGlass);
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(redDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}  SOURCE  {source_file} .");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_pinkDir = System.IO.Path.Combine(pinkDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_pinkDir);
                logLIst.Items.Add($"{move_pinkDir}||  SOURCE  {source_file} .");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];// 在获取一些文件名时，会因为某些特殊的名称例如()等东西，提前截取了，导致没有后缀名，从而报错！
                string move_yellowDir = System.IO.Path.Combine(yellowDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_yellowDir);
                logLIst.Items.Add($"{move_yellowDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(orangeDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(blueDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(purpleDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(greenDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(cyanDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(whiteDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(colorDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}|| SOURCE  {source_file} .");
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(darkDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(delDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");
             
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(blackDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(brownDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(backgroundDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                if (File.Exists(move_redDir))
                {
                    
                    logLIst.Items.Add($"Error 23!");
                    
                }
                else
                {
                    File.Move(source_file, move_redDir);
                    logLIst.Items.Add($"{move_redDir} ||  SOURCE  {source_file} .");
                }
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(womenDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                if (File.Exists(move_redDir))
                {

                    logLIst.Items.Add($"Error 23!");

                }
                else
                {
                    File.Move(source_file, move_redDir);
                    logLIst.Items.Add($"{move_redDir} ||  SOURCE  {source_file} .");
                }
            }

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(multileDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");

            }
        }
        
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_redDir = System.IO.Path.Combine(materDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_redDir);
                logLIst.Items.Add($"{move_redDir}||  SOURCE  {source_file} .");

            }
        }
    }

    public static class GETWindow
    {
        public static AutomationElement FindConditions()
        {
            AutomationElement rootElement = AutomationElement.RootElement; 
            System.Windows.Automation.Condition conditions = new AndCondition(
              new PropertyCondition(AutomationElement.AutomationIdProperty, "frmMain"),
              new PropertyCondition(AutomationElement.ClassNameProperty,
                  "WindowsForms10.Window.8.app.0.2bf8098_r8_ad1")
              );

            // Find all children that match the specified conditions.
            return rootElement.FindFirst(TreeScope.Element | TreeScope.Children, conditions);
        }

        public static string GetNowDir(AutomationElement? flag)
        {
            if (flag != null)
            {
                flag.SetFocus();
                SendKeys.SendWait(@"^l");
                return Path.GetDirectoryName(System.Windows.Clipboard.GetText());
            }
            else
            {
                throw new Exception("没有目标程序运行");
            }
        }
    }
}