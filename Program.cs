using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HolaMundo.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HolaMundo {
    public class Program {
        public static void Main (string[] args) {
            using (var scope = BuildWebHost (args).Services.CreateScope ()) {
                var services = scope.ServiceProvider;
                try {
                    //Requiere using HolaMundo.Models
                    SeedData.Initialize (services);
                } catch (System.Exception e) {
                    var logger = services.GetRequiredService<ILogger<Program>> ();
                    logger.LogError (e, "Ocurrio un error llenando la base de datos");
                }
            }
            BuildWebHost (args).Run ();
        }

        public static IWebHost BuildWebHost (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .UseStartup<Startup> ()
            .Build ();
    }
}