using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using System.Diagnostics;

namespace AspNet5TraceTest
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
				Trace.WriteLine("Processing request");
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
