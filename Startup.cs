using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DesignPatternsInC_Sharp.ObserverPattern;
//using DesignPatternsInC_Sharp.AbstractFactoryPattern;
//using DesignPatternsInC_Sharp.SingletonPattern;
//using DesignPatternsInC_Sharp.FactoryMethodPattern;
//using DesignPatternsInC_Sharp.SimpleFactoryPattern;


namespace DesignPatternsInC_Sharp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor(); //or services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    #region Comment all except this region to check Simple Factory Pattern Demo & Include SimpleFactoryPattern namaspace only
                    //await context.Response.WriteAsync("*** TechWebDots: Simple Factory Pattern Demo***\n\n");
                    //IAnimal preferredType = null;
                    //ISimpleFactory simpleFactory = new SimpleFactory();
                    //#region The code region that will vary based on userspreference
                    //await context.Response.WriteAsync("Factory can accept (0 for Dog, 1 for Tiger)\n\n");
                    //await context.Response.WriteAsync("Passing (0 for Dog) to Create Dog Animal\n\n");
                    //preferredType = simpleFactory.CreateAnimal(0);
                    //#endregion
                    //await context.Response.WriteAsync("Dog Animal created and Getting Dog Animal Features\n\n");
                    //#region The codes that do not change frequently
                    //preferredType.Speak();
                    //preferredType.Action();
                    //#endregion
                    #endregion

                    #region Comment all except this region to check Factory Method Design Pattern Demo, Include SimpleFactoryPattern & FactoryMethodPattern namaspace only
                    //await context.Response.WriteAsync("*** TechWebDots: Factory Method Design Pattern Demo***\n\n");
                    //IAnimalFactory dogFactory = new DogFactory();
                    //#region The code region that will vary based on userspreference
                    //await context.Response.WriteAsync("Dog Factory can create only Dog Animals!\n\n");
                    //IAnimal aDog = dogFactory.MakeAnimal();
                    ////IAnimal aDog = dogFactory.CreateAnimal();
                    //#endregion
                    //await context.Response.WriteAsync("Dog Animal created and Getting Dog Animal Features!\n\n");
                    //#region The codes that do not change frequently
                    ////aDog.Speak();
                    ////aDog.Action();
                    //#endregion
                    #endregion

                    #region Comment all except this region to check Abstract Factory Design Pattern Demo & Include AbstractFactoryPattern namaspace only
                    //await context.Response.WriteAsync("*** TechWebDots: Factory Method Design Pattern Demo***\n\n");

                    //await context.Response.WriteAsync("*** TechWebDots: Making a wild tiger through WildAnimalFactory ***\n\n");
                    ////Making a wild tiger through WildAnimalFactory
                    //IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
                    //ITiger wildTiger = wildAnimalFactory.GetTiger();
                    //wildTiger.Speak();
                    //wildTiger.Action();

                    //await context.Response.WriteAsync("*** TechWebDots: Making a pet dog through PetAnimalFactory ***\n\n");
                    ////Making a pet dog through PetAnimalFactory
                    //IAnimalFactory petAnimalFactory = new PetAnimalFactory();
                    //IDog petDog = petAnimalFactory.GetDog();
                    //petDog.Speak();
                    //petDog.Action();

                    #endregion

                    #region Comment all except this region to check Singleton Pattern Demo & Include SingletonPattern namaspace only
                    //await context.Response.WriteAsync("***Singleton Pattern Demo***\n\n");                    
                    //await context.Response.WriteAsync("Trying to create instance s1.\n\n");
                    //Singleton s1 = Singleton.Instance;
                    //await context.Response.WriteAsync("Trying to create instance s2.\n\n");
                    //Singleton s2 = Singleton.Instance;
                    //if (s1 == s2)
                    //{
                    //    await context.Response.WriteAsync("Only one instance exists.\n\n");
                    //}
                    //else
                    //{
                    //    await context.Response.WriteAsync("Different instances exist.\n\n");
                    //}
                    //await context.Response.WriteAsync("***Thread-Safe Singleton Pattern Demo***\n\n");
                    //SingletonTS sts = SingletonTS.Instance;
                    #endregion

                    #region Comment all except this region to check observer Pattern Demo & Include ObserverPattern namaspace only
                    await context.Response.WriteAsync("***Observer Pattern Demo***\n");
                    //We have 3 observers-2 of them are ObserverType1, 1 of them is of ObserverType2
                    IObserver myObserver1 = new ObserverType1("DB Subscriber 1");
                    IObserver myObserver2 = new ObserverType1("DB Subscriber 2");
                    IObserver myObserver3 = new ObserverType2("DB Subscriber 3");
                    Subject subject = new Subject();
                    //Registering the observers-DB Users
                    subject.Register(myObserver1);
                    subject.Register(myObserver2);
                    subject.Register(myObserver3);
                    await context.Response.WriteAsync("Updating Flag = 5 \n");
                    subject.Flag = 5;
                    //Unregistering an observer(DB Subscriber 1))
                    subject.Unregister(myObserver1);
                    //No notification this time DB Subscriber 1. Since it is unregistered.
                    await context.Response.WriteAsync("\nUpdating Flag = 50 \n");
                    subject.Flag = 50;
                    //DB Subscriber 1 is registering himself again
                    subject.Register(myObserver1);
                    await context.Response.WriteAsync("\nUpdating Flag = 100 \n");
                    subject.Flag = 100;
                    #endregion
                    await context.Response.WriteAsync("\n");

                });
            });
        }
    }
}
