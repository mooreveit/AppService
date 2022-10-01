﻿

using AppService.Core.CustomEntities;
using AppService.Core.Interfaces;
using AppService.Core.Services;
using AppService.Infrastructure.Data;
using AppService.Infrastructure.DataClientes;
using AppService.Infrastructure.DataContratosStock;
using AppService.Infrastructure.DataCXC;
using AppService.Infrastructure.DataDW;
using AppService.Infrastructure.DataFacturacion;
using AppService.Infrastructure.DataMaestros;
using AppService.Infrastructure.DataMc;
using AppService.Infrastructure.DataMooreve;
using AppService.Infrastructure.DataNomina;
using AppService.Infrastructure.DataSap;
using AppService.Infrastructure.DataSpi;
using AppService.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{



    internal static IConfigurationRoot Configuration;

    private static async Task Main(string[] args)
    {

        var configurationBuilder = new ConfigurationBuilder();
        configurationBuilder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        // configurationBuilder.AddUserSecrets(typeof(Program).GetTypeInfo().Assembly, optional: false);
        Configuration = configurationBuilder.Build();

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        string rrdConection = "Server=172.28.107.19;Database=RRD;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string mooreveConecction = "Server=172.28.107.19\\FSVEMCYN03D;Database=Mooreve;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string mcConecction = "Server=172.28.107.19\\FSVEMCYN03D;Database=MC;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string maestrosConecction = "Server=172.28.107.19\\FSVEMCYN03D;Database=Maestros;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string sapConecction = "Server=172.28.107.19;Database=SAP;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string clientesConecction = "Server=172.28.107.19\\FSVEMCYN03D;Database=Clientes;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string facturacionConecction = "Server=172.28.107.19\\FSVEMCYN03D;Database=Facturacion;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string contratosStockConecction = "Server=172.28.107.19\\FSVEMCYN03D;Database=Contratos Stock;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string dwConecction = "Server=172.28.107.19\\FSVEMCYN03D;Database=DW;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string nominaConecction = "Server=172.28.107.19\\FSVEMCYN03D;Database=Nomina;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";
        string cxcConecction = "Server=172.28.107.19\\FSVEMCYN03D;Database=CXC;User Id=userweb;Password=userweb2003;MultipleActiveResultSets=true";

        string spiConnection = "Data Source=172.28.107.20:1521/SPI;User Id=INFOCENT;Password=SPISENIOR;Validate Connection=true;";

        serviceCollection.Configure<PaginationOptions>(Configuration.GetSection("Pagination"));

        serviceCollection.AddDbContext<RRDContext>(options =>
        {
            options.UseSqlServer(rrdConection);

        });

        serviceCollection.AddDbContext<SapContext>(options =>

         options.UseSqlServer(sapConecction)

          );

        serviceCollection.AddDbContext<MooreveContext>(options =>
        {
            options.UseSqlServer(mooreveConecction);

        });

        serviceCollection.AddDbContext<ClientesContext>(options =>

          options.UseSqlServer(clientesConecction)

           );


        serviceCollection.AddDbContext<MCContext>(options =>

        options.UseSqlServer(mcConecction)

         );

        serviceCollection.AddDbContext<CXCContext>(options =>

            options.UseSqlServer(cxcConecction)

        );
        serviceCollection.AddDbContext<IMaestrosContext>(options =>

           options.UseSqlServer(maestrosConecction)

       );

        serviceCollection.AddDbContext<FacturacionContext>(options =>

                      options.UseSqlServer(facturacionConecction)

                  );

        serviceCollection.AddDbContext<ContratosStockContext>(options =>

          options.UseSqlServer(contratosStockConecction)

      );
        serviceCollection.AddDbContext<DWContext>(options =>

          options.UseSqlServer(dwConecction)

      );

        serviceCollection.AddDbContext<NominaContext>(options =>

           options.UseSqlServer(nominaConecction)
      );


        serviceCollection.AddDbContext<SpiContext>(options =>
                options.UseOracle(spiConnection, b => b.UseOracleSQLCompatibility("11")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
      );

        serviceCollection.AddTransient<IAppConfigAppService, AppConfigAppService>();
        serviceCollection.AddTransient<IAppVariablesService, AppVariablesService>();
        serviceCollection.AddTransient<IHelperService, HelperService>();
        serviceCollection.AddTransient<IAppRecipesByAppDetailQuotesService, AppRecipesByAppDetailQuotesService>();

        serviceCollection.AddTransient<IAppTemplateConversionUnitService, AppTemplateConversionUnitService>();
        serviceCollection.AddTransient<IAppDetailQuotesConversionUnitService, AppDetailQuotesConversionUnitService>();

        serviceCollection.AddTransient<IMtrContactosService, MtrContactosService>();
        serviceCollection.AddTransient<IAppProductConversionService, AppProductConversionService>();
        serviceCollection.AddTransient<IAppSubCategoryService, AppSubCategoryService>();
        serviceCollection.AddTransient<IAppVariableSearchService, AppVariableSearchService>();
        serviceCollection.AddTransient<IAppProductVariableSearchTextService, AppProductVariableSearchTextService>();
        serviceCollection.AddTransient<IAppProductsService, AppProductsService>();
        serviceCollection.AddHttpClient<IOdooClient, OdooClient>();
        serviceCollection.AddTransient<IAprobacionesServices, AprobacionesServices>();
        serviceCollection.AddTransient<IAppUnitsService, AppUnitsService>();
        serviceCollection.AddTransient<IMtrTipoMonedaService, MtrTipoMonedaService>();
        serviceCollection.AddTransient<ICotizacionService, CotizacionService>();
        serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();

        var serviceProvider = serviceCollection.BuildServiceProvider();


        var cotizacionServices = serviceProvider.GetRequiredService<ICotizacionService>();
        Console.WriteLine("Iniciando envio de cotizaciones a Odoo");
        await cotizacionServices.UpdateCotizacionesToOdoo();
        Console.WriteLine("Culminado envio de cotizaciones a Odoo");
    }
}