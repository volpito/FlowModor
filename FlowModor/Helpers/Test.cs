using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowModor.Helpers
{
    internal class Test
    {
        public void Main(string[] args)
        {
            BackgroundWorker worker = new BackgroundWorker();

            // DoWork event handler
            worker.DoWork += (sender, e) =>
            {
                // Simulate some work
                for (int i = 0; i < 10; i++)
                {
                    // Check if cancellation is requested
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    // Simulate work by sleeping for 1 second
                    //Thread.Sleep(1000);

                    // Report progress
                    worker.ReportProgress(i * 10);
                }
            };

            // ProgressChanged event handler
            worker.ProgressChanged += (sender, e) =>
            {
                // This is called when ReportProgress is called from the DoWork event handler
                Console.WriteLine($"Progress: {e.ProgressPercentage}%");
            };

            // RunWorkerCompleted event handler
            worker.RunWorkerCompleted += (sender, e) =>
            {
                // This is called when the background work is completed or cancelled
                if (e.Cancelled)
                {
                    Console.WriteLine("Operation was cancelled.");
                }
                else if (e.Error != null)
                {
                    Console.WriteLine($"An error occurred: {e.Error.Message}");
                }
                else
                {
                    Console.WriteLine("Operation completed successfully.");
                }
            };

            // Start the background operation
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();

            // You can also cancel the operation if needed
            // worker.CancelAsync();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}

