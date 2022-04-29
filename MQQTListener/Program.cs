using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using MQQTListener.Models;

using System.Diagnostics;
using System.Net.Mqtt;
using System.Reflection;
using System.Runtime.InteropServices;

namespace MQQTListener;
public static class Program
{


    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<ServiceWorker>();
            });


    public static async Task Main(string[] args)
    {

        IntPtr handle = Process.GetCurrentProcess().MainWindowHandle;

        // Hide

//#if DEBUG
//        ShowWindow(handle, SW_HIDE);
//#else
//        ShowWindow(handle, SW_HIDE);
//#endif

        await CreateHostBuilder(args).UseWindowsService(x =>
        {
            x.ServiceName = "MQTTListenerAppLauncher";
        }).Build().RunAsync();


     


    }

    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    const int SW_HIDE = 0;
    const int SW_SHOW = 5;
}

