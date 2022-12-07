using DogBNB.IServices;
using DogBNB.Repositories;
using DogBNB.Repositories.Interfaces;
using DogBNB.Services;
using DogBNB.Services.Interfaces;
using DogBNB.Services.IServices;
using DogBNB_Db;
using Microsoft.EntityFrameworkCore;

namespace DogBNB_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DogBNBDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IDogRepository, DogRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IChatRepository,ChatRepository>();
            services.AddScoped<ISitterRepository,SitterRepository>();
            services.AddScoped<ICallendarRepository,CallendarRepository>();
            services.AddScoped<IUserRepository,UserRepository>();

            services.AddScoped<IDogService, DogService>();
            services.AddScoped<ICallendarService,CallendarService>();
            services.AddScoped<IChatService,ChatService>();
            services.AddScoped<IOrderService,OrderService>();
            services.AddScoped<IReviewService,ReviewService>();
            services.AddScoped<IServiceService,ServiceService>();
            services.AddScoped<ISitterService,SitterService>();
            services.AddScoped<IUserService,UserService>();




            services.AddScoped<IMessageService,MessageService>();


            services.AddControllers();


        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
