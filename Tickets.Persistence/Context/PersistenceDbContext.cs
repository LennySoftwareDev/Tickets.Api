using Microsoft.EntityFrameworkCore;
using Tickets.Domain.Tickets;
using Tickets.Domain.User;
using Tickets.Persistence.Base.Context;

namespace Tickets.Persistence.Context;

public class PersistenceDbContext : DbContextBase, IPersistenceDbContext
{
    public PersistenceDbContext(DbContextOptions<PersistenceDbContext> options) : base(options)
    {
    }

    public virtual DbSet<TicketEntity> Ticket { get; set; }
    public virtual DbSet<UserEntity> User { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    modelBuilder.Entity<TipoPuntoSastEntity>().HasData(new TipoPuntoSastEntity
    //    {
    //        TipoPuntoSastId = 3,
    //        DetalleTipoPuntoSast = "Detalle"
    //    });

    //    modelBuilder.Entity<TipoPuntoSastEntity>().HasData(new TipoPuntoSastEntity
    //    {
    //        TipoPuntoSastId = 4,
    //        DetalleTipoPuntoSast = "Detalle"
    //    });

    //    modelBuilder.Entity<PuntoSastEntity>().HasData(new PuntoSastEntity
    //    {
    //        CiudadId = 3,
    //        DescripcionSast = "Descripción",
    //        DireccionPuntoSast = "Dirección",
    //        EstadoPuntoSastId = 3,
    //        FechaInicioOperacionPuntoSast = DateTime.Now,
    //        LatitudPuntoSast = "3",
    //        LongitudPuntoSast = "3",
    //        NombreSast = "Nombre",
    //        NumeroAutorizacionPuntoSast = "3",
    //        PuntoSastId = 3,
    //        ResolucionAprobacionPuntoSast = "Resolución",
    //        TipoPuntoSastId = 3
    //    });

    //    modelBuilder.Entity<PuntoSastEntity>().HasData(new PuntoSastEntity
    //    {
    //        CiudadId = 4,
    //        DescripcionSast = "Descripción",
    //        DireccionPuntoSast = "Dirección",
    //        EstadoPuntoSastId = 4,
    //        FechaInicioOperacionPuntoSast = DateTime.Now,
    //        LatitudPuntoSast = "4",
    //        LongitudPuntoSast = "4",
    //        NombreSast = "Nombre",
    //        NumeroAutorizacionPuntoSast = "4",
    //        PuntoSastId = 4,
    //        ResolucionAprobacionPuntoSast = "Resolución",
    //        TipoPuntoSastId = 4
    //    });

    //    modelBuilder.Entity<FotoDeteccionEntity>().HasData(new FotoDeteccionEntity
    //    {
    //        FotoDeteccionId = 3,
    //        FechaFotoDeteccion = DateTime.Now,
    //        FechaRegistro = DateTime.Now.AddHours(1),
    //        PuntoSastFotoDeteccionId = 3,
    //        PuntoSast = null,
    //        InfraccionFotoDeteccionId = 3,
    //        PlacaVehiculoFotoDeteccion = "123",
    //        VelocidadFotoDeteccion = 3,
    //        PropietarioVehiculoFotoDeteccionId = 3,
    //        OrganismoTransitoFotoDeteccionId = 3,
    //        UsuarioCargaFotoDeteccionId = "3",
    //        AgenteValidaFotoDeteccionId = 3,
    //        EstadoFotoDeteccionId = 3,
    //        MotivoRechazaFotodeteccion = "rechazado fotodección",
    //        EstadoAsociacionVPFotoDeteccionId = 3,
    //        EstadoEvidenciasId = 3,
    //        IsFotomulta = true,
    //        ConsecutivoFotoMulta = "consecutivo",
    //        EstadoValidacionId = 3
    //    });

    //    modelBuilder.Entity<FotoDeteccionEntity>().HasData(new FotoDeteccionEntity
    //    {
    //        FotoDeteccionId = 4,
    //        FechaFotoDeteccion = DateTime.Now,
    //        FechaRegistro = DateTime.Now.AddHours(1),
    //        PuntoSastFotoDeteccionId = 4,
    //        PuntoSast = null,
    //        InfraccionFotoDeteccionId = 4,
    //        PlacaVehiculoFotoDeteccion = "123",
    //        VelocidadFotoDeteccion = 4,
    //        PropietarioVehiculoFotoDeteccionId = 4,
    //        OrganismoTransitoFotoDeteccionId = 4,
    //        UsuarioCargaFotoDeteccionId = "4",
    //        AgenteValidaFotoDeteccionId = 4,
    //        EstadoFotoDeteccionId = 4,
    //        MotivoRechazaFotodeteccion = "rechazado fotodección",
    //        EstadoAsociacionVPFotoDeteccionId = 4,
    //        EstadoEvidenciasId = 4,
    //        IsFotomulta = true,
    //        ConsecutivoFotoMulta = "consecutivo",
    //        EstadoValidacionId = 4
    //    });
}
