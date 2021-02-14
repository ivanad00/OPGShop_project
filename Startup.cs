using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OPG.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace OPG
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<StoreUser> ().AddEntityFrameworkStores<AppDbContext> ();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderFormRepository, OrderFormRepository> ();

            services.AddScoped<Order> ( sp => Order.GetOrder( sp ) );
            
            services.AddHttpContextAccessor ();
            services.AddSession ();
            services.AddControllersWithViews();
            services.AddRazorPages ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseNodeModules ();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession ();
            app.UseRouting();
            app.UseAuthentication ();
            app.UseAuthorization ();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller}/{action}/{id?}",
                    new {controller="home", action="index"}
                    );
                endpoints.MapRazorPages ();
                endpoints.MapControllerRoute (
                    name: "Products",
                    pattern: "{controller}/{action}/{id?}",
                    new { controller = "Product", action = "List" }
                    );
                endpoints.MapControllerRoute (
                    name: "Register",
                    pattern: "{controller}/{action}/{id?}",
                    new { controller = "Form", action = "login" }
                    );
                endpoints.MapControllerRoute (
                    name: "ShoppingCart",
                    pattern: "{controller}/{action}/{id?}",
                    new { controller = "Order", action = "Cart" }
                    );
                endpoints.MapControllerRoute (
                    name: "Contact",
                    pattern: "{controller}/{action}/{id?}",
                    new { controller = "Contact", action = "Index" }
                    );
            } );
        }
    }
}
