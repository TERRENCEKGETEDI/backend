using Microsoft.EntityFrameworkCore;
using UserManagementApp.Models;

namespace UserManagementApp.Data
{
    public class UserManagementAppDbContext : DbContext
    {
        public UserManagementAppDbContext(DbContextOptions<UserManagementAppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Univarsity> Univarsities => Set<Univarsity>();
        public DbSet<Campus> Campuses => Set<Campus>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Declare GUIDs for Universities 
            var nwuId     = Guid.NewGuid();
            var uctId     = Guid.NewGuid();
            var ukznId    = Guid.NewGuid();
            var witsId    = Guid.NewGuid();
            var ujId      = Guid.NewGuid();
            var suId      = Guid.NewGuid();
            var cputId    = Guid.NewGuid();
            var uzId      = Guid.NewGuid();
            var nmuId     = Guid.NewGuid();
            var upId      = Guid.NewGuid();
            var tutId     = Guid.NewGuid();
            var vutId     = Guid.NewGuid();
            var dutId     = Guid.NewGuid();
            var unisaId   = Guid.NewGuid();
            var cutId     = Guid.NewGuid();
            var ufhId     = Guid.NewGuid();
            var ufsId     = Guid.NewGuid();
            var ulId      = Guid.NewGuid();
            var univenId      = Guid.NewGuid();
            var muId      = Guid.NewGuid();
            var ruId      = Guid.NewGuid();
            var smuId     = Guid.NewGuid();
            var spuId     = Guid.NewGuid();
            var mutId     = Guid.NewGuid();
            var wsuId     = Guid.NewGuid();
            var uwcId     = Guid.NewGuid();

            // Declare GUIDs for Campuses (only those referenced) 
            // NWU
            var potchId       = Guid.NewGuid();
            var vaalId        = Guid.NewGuid();
            var mahikengId    = Guid.NewGuid();

            // UCT
            var uctMainId     = Guid.NewGuid();

            // UKZN
            var edgewoodId    = Guid.NewGuid();
            var howardId      = Guid.NewGuid();
            var medSchoolId   = Guid.NewGuid();
            var pmbId         = Guid.NewGuid();
            var westvilleId   = Guid.NewGuid();

            // WITS
            new Campus { Id = parktownId, UnivarsityId = witsId, CampusCode = "4A", Name = "Parktown Campus" },
                new Campus { Id = braamfonteinId, UnivarsityId = witsId, CampusCode = "4B", Name = "Braamfontein Campus" },

                // UJ
                new Campus { Id = apkId, UnivarsityId = ujId, CampusCode = "5A", Name = "Auckland Park Kingsway (APK)" },
                new Campus { Id = apbId, UnivarsityId = ujId, CampusCode = "5B", Name = "Auckland Park Bunting Road (APB)" },
                new Campus { Id = doornfonteinId, UnivarsityId = ujId, CampusCode = "5C", Name = "Doornfontein Campus" },

                // Stellenbosch Univarsity
                new Campus { Id = suMainId, UnivarsityId = suId, CampusCode = "6A", Name = "Main Campus" },
                new Campus { Id = tygerbergId, UnivarsityId = suId, CampusCode = "6B", Name = "tygerberg Campus" },
                new Campus { Id = BellvilleParkId, UnivarsityId = suId, CampusCode = "6C", Name = "Bellville Park Campus" },
                new Campus { Id = saldanhaId, UnivarsityId = suId, CampusCode = "6D", Name = "Saldanha Campus" },

                // Cape Peninsula Univarsity of Technology
                new Campus { Id = BellvilleId, UnivarsityId = cputId, CampusCode = "7A", Name = "Bellville Campus" }, 
                new Campus { Id = GrangerBayCampusId, UnivarsityId = cputId, CampusCode = "7B", Name = "Granger Bay Campus" }, 
                new Campus { Id = MowbrayId, UnivarsityId = cputId, CampusCode = "7C", Name = "Mowbray Campus" }, 
                new Campus { Id = AthloneId, UnivarsityId = cputId, CampusCode = "7D", Name = "Athlone Campus" }, 
                new Campus { Id = Wellington CampusId, UnivarsityId = cputId, CampusCode = "7E", Name = "Wellington Campus" },

                // Univarsity of Zululand
                new Campus { Id = KwaDlangezwaId, UnivarsityId = uzId, CampusCode = "8A", Name = "KwaDlangezwa Campus" }, 
                new Campus { Id = RichardBayId, UnivarsityId = uzId, CampusCode = "8B", Name = "Richards Bay Campus" },

                // Nelson Mandela Univarsity
                new Campus { Id = SummerstrandId, UnivarsityId = nmuId, CampusCode = "9A", Name = "Summerstrand Campus" }, 
                new Campus { Id = SecondAvenueId, UnivarsityId = nmuId, CampusCode = "9B", Name = "Second Avenue Campus" }, 
                new Campus { Id = BirdStreetId, UnivarsityId = nmuId, CampusCode = "9C", Name = "Bird Street Campus" }, 
                new Campus { Id = MissionvaleId, UnivarsityId = nmuId, CampusCode = "9D", Name = "Missionvale Campus" }, 
                new Campus { Id = NorthId, UnivarsityId = nmuId, CampusCode = "9E", Name = "North Campus" }, 
                new Campus { Id = SouthId, UnivarsityId = nmuId, CampusCode = "9F", Name = "South Campus" }, 
                new Campus { Id = OceanSciencesId, UnivarsityId = nmuId, CampusCode = "9G", Name = "Ocean Sciences Campus" },

                // Univarsity of Pretoria
                new Campus { Id = HatfieldId, UnivarsityId = upId, CampusCode = "10A", Name = "Hatfield Campus" }, 
                new Campus { Id = OnderstepoortId, UnivarsityId = upId, CampusCode = "10B", Name = "Onderstepoort Campus" }, 
                new Campus { Id = GroenkloofId, UnivarsityId = upId, CampusCode = "10C", Name = "Groenkloof Campus" }, 
                new Campus { Id = PrinshofId, UnivarsityId = upId, CampusCode = "10D", Name = "Prinshof Campus" }, 
                new Campus { Id = HillcrestId, UnivarsityId = upId, CampusCode = "10E", Name = "Hillcrest Campus" },
                new Campus { Id = MamelodiId, UnivarsityId = upId, CampusCode = "10E", Name = "Mamelodi Campus" },

                // Tshwane Univarsity of Technology
                new Campus { Id = PretoriaMainId, UnivarsityId = tutId, CampusCode = "11A", Name = "Pretoria Main Campus" }, 
                new Campus { Id = SoshanguveNorthId, UnivarsityId = tutId, CampusCode = "11B", Name = "Soshanguve North Campus" }, 
                new Campus { Id = SoshanguveSouthId, UnivarsityId = tutId, CampusCode = "11C", Name = "Soshanguve South Campus" },
                new Campus { Id = ArcadiaId, UnivarsityId = tutId, CampusCode = "11D", Name = "Arcadia Campus" },
                new Campus { Id = ArtsId, UnivarsityId = tutId, CampusCode = "11E", Name = "Arts Campus" },
                new Campus { Id = Ga-rankuwaId, UnivarsityId = tutId, CampusCode = "11F", Name = "Ga-rankuwa Campus" },
                new Campus { Id = EmalahleniId, UnivarsityId = tutId, CampusCode = "11G", Name = "Emalahleni Campus" },
                new Campus { Id = MbombelaId, UnivarsityId = tutId, CampusCode = "11H", Name = "Mbombela Campus" },
                new Campus { Id = PolokwaneId, UnivarsityId = tutId, CampusCode = "11I", Name = "Polokwane Campus" },

                // Vaal Univarsity of Technology
                new Campus { Id = VUTMainId, UniversityId = vutId, CampusCode = "12", Name = "Vaal Univarsity of Technology" },

                // Durban Univarsity of Technology
                new Campus { Id = BrickfieldId, UnivarsityId = dutId, CampusCode = "13A", Name = "Brickfield Campus" }, 
                new Campus { Id = CityId, UnivarsityId = dutId, CampusCode = "13B", Name = "City Campus" }, 
                new Campus { Id = IndumisoId, UnivarsityId = dutId, CampusCode = "13C", Name = "Indumiso Campus" }, 
                new Campus { Id = MLSultanId, UnivarsityId = dutId, CampusCode = "13D", Name = "ML Sultan Campus" }, 
                new Campus { Id = RitsonId, UnivarsityId = dutId, CampusCode = "13E", Name = "Ritson Campus" }, 
                new Campus { Id = RiversideId, UnivarsityId = dutId, CampusCode = "13F", Name = "Riverside Campus" }, 
                new Campus { Id = SteveBikoId, UnivarsityId = dutId, CampusCode = "13G", Name = "Steve Biko Campus" },

                // UNISA
                 new Campus { Id = UNISAId, UnivarsityId = unisaId, CampusCode = "14", Name = "UNISA" },

                // Central Univarsity of Technology
                new Campus { Id = BloemId, UnivarsityId = cutId, CampusCode = "15A", Name = "Bloemfontein Campus" },
                new Campus { Id = WelkomId, UnivarsityId = cutId, CampusCode = "15B", Name = "Welkom Campus" },

                // Univarsity of Fort Hare
                new Campus { Id = AliceId, UnivarsityId = ufhId, CampusCode = "16A", Name = "Alice Campus" }, 
                new Campus { Id = EastLondonId, UnivarsityId = ufhId, CampusCode = "16B", Name = "East London Campus" }, 
                new Campus { Id = BishoId, UnivarsityId = ufhId, CampusCode = "16C", Name = "Bisho Campus" },

                // Univarsity of Free State
                 new Campus { Id = BloemfonteinId, UnivarsityId = ufsId, CampusCode = "17A", Name = "Bloemfontein Campus" }, 
                new Campus { Id = SouthId, UnivarsityId = ufsId, CampusCode = "17B", Name = "South Campus" }, 
                new Campus { Id = QwaqwaId, UnivarsityId = ufsId, CampusCode = "17C", Name = "Qwaqwa Campus" },

                // Univarsity of Limpopo
                new Campus { Id = ulMainId, UnivarsityId = ulId, CampusCode = "18", Name = "Univarsity of Limpopo" }

                // Univarsity of Venda
                new Campus { Id = univenId, UnivarsityId = uvId, CampusCode = "19", Name = "Univarsity of Venda" },

                // Univarsity of Mpumalanga
                new Campus { Id = MbombelaId, UnivarsityId = muId, CampusCode = "20A", Name = " Mbombela Campus" },
                new Campus { Id = SiyabuswaId, UnivarsityId = muId, CampusCode = "20B", Name = " Siyabuswa Campus" },

                // Rhodes University
                new Campus { Id = ruMainId, UnivarsityId = ruId, CampusCode = "21", Name = "Rhodes Univarsity" },

                // Sefako Makgatho Health Sciences Univarsity
                new Campus { Id = smuMainId, UnivarsityId = smuId, CampusCode = "22A", Name = "SMU Main Campus" },

                // Sol Plaatje Univarsity
                new Campus { Id = NorthId, UnivarsityId = spuId, CampusCode = "23A", Name = "North Campus" }, 
                new Campus { Id = SouthId, UnivarsityId = spuId, CampusCode = "23B", Name = "South Campus" }, 
                new Campus { Id = CentralId, UnivarsityId = spuId, CampusCode = "23C", Name = "Central Campus" },

                // Mangosuthu University of Technology
                new Campus { Id = MainId, UniversityId = mutId, CampusCode = "24A", Name = "Main Campus" }, 
                new Campus { Id = NorthId, UniversityId = mutId, CampusCode = "24B", Name = "North Campus" },

                // Walter Sisulu Univarsity
                new Campus { Id = MthathaId, UnivarsityId = wsuId, CampusCode = "25A", Name = "Mthatha Campus" }, 
                new Campus { Id = ButterworthId, UnivarsityId = wusId, CampusCode = "25B", Name = "Butterworth Campus" }, 
                new Campus { Id = BuffaloCityId, UnivarsityId = wsuId, CampusCode = "25C", Name = "Buffalo City Campus" }, 
                new Campus { Id = KomaniId, UnivarsityId = wsuId, CampusCode = "25D", Name = "Komani Campus" }, 
                new Campus { Id = TygerbergId, UnivarsityId = wusCId, CampusCode = "25E", Name = "Tygerberg Campus" },

                // Univarsity of Western Cape
                new Campus { Id = TygerbergId, UnivarsityId = uwcId, CampusCode = "26A", Name = "Tygerberg Campus" },
                new Campus { Id = BellvilleId, UnivarsityId = uwcId, CampusCode = "26B", Name = "Bellville Campus" },
  
            );
        }
    }
}
