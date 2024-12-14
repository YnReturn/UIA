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
        private string delDir = @"E:\photograph\TEMP";
        //string sourceDir = @"E:\photograph\TODO";

        private string oneDir = @"E:\photograph\模型库\优秀人像图\活泼开朗";
        private string twoDir = @"E:\photograph\模型库\优秀人像图\清冷凛然";
        private string threeDir = @"E:\photograph\模型库\优秀人像图\正经刚直";
        private string fourDir = @"E:\photograph\模型库\优秀人像图\率直纯真";
        private string fiveDir = @"E:\photograph\模型库\优秀人像图\狡猾诡谲";
        private string sixDir = @"E:\photograph\模型库\优秀人像图\伪善虚伪";
        private string sevenDir = @"E:\photograph\模型库\优秀人像图\和婉温雅";
        private string eightDir = @"E:\photograph\模型库\优秀人像图\坚韧坚毅";
        private string nineDir = @"E:\photograph\模型库\优秀人像图\急性暴烈";
        private string tenDir = @"E:\photograph\模型库\优秀人像图\粗暴凶横";
        private string elevenDir = @"E:\photograph\模型库\优秀人像图\狰狞暴虐胆小腼腆";
        private string twelveDir = @"E:\photograph\模型库\优秀人像图\胆小腼腆";
        private string thirteenDir = @"E:\photograph\模型库\优秀人像图\狰狞暴虐";
        private string fourteenDir = @"E:\photograph\模型库\优秀人像图\冷漠妖媚";
        static AutomationElement ImageGlass = GETWindow.FindConditions();
        string sourceDir = GETWindow.GetNowDir(ImageGlass);
        public MainWindow()
        {
            InitializeComponent();

            string[] folderNames = {
            oneDir,
            twoDir,
            threeDir,
            fourDir,
            fiveDir,
            sixDir,
            sevenDir,
            eightDir,
            nineDir,
            tenDir,
            elevenDir,
            twelveDir,
            thirteenDir,
            fourteenDir,
            };

            foreach (string folderPath in folderNames)
            {
                try
                {
                    // 检查文件夹是否存在
                    if (!Directory.Exists(folderPath))
                    {
                        // 如果不存在，则创建文件夹
                        Directory.CreateDirectory(folderPath);
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("创建文件夹时发生错误: " + ex.Message);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(delDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }





        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(oneDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(twoDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(threeDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(fourDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(fiveDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(sixDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(sevenDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(eightDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(nineDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(tenDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(elevenDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(twelveDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(thirteenDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (ImageGlass != null)
            {
                string namePropImageGlass = ImageGlass.GetCurrentPropertyValue(AutomationElement.NameProperty, true) as string;
                string file_name = namePropImageGlass.Split(' ')[0];
                string move_fileDir = System.IO.Path.Combine(fourteenDir, file_name);
                string source_file = System.IO.Path.Combine(sourceDir, file_name);
                File.Move(source_file, move_fileDir);
                logLIst.Items.Add($"{move_fileDir}||  SOURCE  {source_file} .");

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