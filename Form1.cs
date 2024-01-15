using System.Drawing.Text;

namespace problem1Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string appendingText = String.Empty;
        private void btnThread_Click(object sender, EventArgs e)
        {
            void printFunc()
            {
                appendingText += $"Thread number is {Thread.CurrentThread.GetHashCode()}\n";
                threadRichText.Text = appendingText;
                //threadRichText.AppendText(threadRichText.Text = $"Thread number is {Thread.CurrentThread.GetHashCode()}");
            }
            Random rand = new Random();
            int n = rand.Next(1,6);
            //threadRichText.Text = $"n = {n}";
            //Thread[] arr = new Thread[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = new Thread(printFunc);
            //    //arr[i] = new Thread(new ParameterizedThreadStart(count(i));
            //    arr[i].Start();
            //}

            Thread t1 = new Thread(new ThreadStart(printFunc));
            t1.Start();
        }

        private static void printFunc1()
        {

        }


    }
}
