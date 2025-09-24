using Microsoft.EntityFrameworkCore;
using UserManagementApp.Models;

namespace UserManagementApp.Data
{
    public class UserManagementAppDbContext : DbContext
    {
        public UserManagementAppDbContext(DbContextOptions<UserManagementAppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<University> Univarsities => Set<Univarsity>();
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
                new Campus { Id = bellvilleParkId, UnivarsityId = suId, CampusCode = "6C", Name = "Bellville Park Campus" },
                new Campus { Id = saldanhaId, UnivarsityId = suId, CampusCode = "6D", Name = "Saldanha Campus" },

                // Cape Peninsula Univarsity of Technology
                new Campus { Id = bellvilleId, UnivarsityId = CPUTId, CampusCode = "7A", Name = "Bellville Campus" }, 
                new Campus { Id = GrangerBayCampusId, UnivarsityId = CPUTId, CampusCode = "7B", Name = "Granger Bay Campus" }, 
                new Campus { Id = MowbrayId, UnivarsityId = CPUTId, CampusCode = "7C", Name = "Mowbray Campus" }, 
                new Campus { Id = AthloneId, UnivarsityId = CPUTId, CampusCode = "7D", Name = "Athlone Campus" }, 
                new Campus { Id = Wellington CampusId, UnivarsityId = CPUTId, CampusCode = "7E", Name = "Wellington Campus" },

                // Univarsity of Zululand
                new Campus { Id = KwaDlangezwaId, UnivarsityId = UZId, CampusCode = "8A", Name = "KwaDlangezwa Campus" }, 
                new Campus { Id = RichardBayId, UnivarsityId = UZId, CampusCode = "8B", Name = "Richards Bay Campus" },

                // Nelson Mandela Univarsity
                new Campus { Id = SummerstrandId, UnivarsityId = NMUId, CampusCode = "9A", Name = "Summerstrand Campus" }, 
                new Campus { Id = SecondAvenueId, UnivarsityId = NMUId, CampusCode = "9B", Name = "Second Avenue Campus" }, 
                new Campus { Id = BirdStreetId, UnivarsityId = NMUId, CampusCode = "9C", Name = "Bird Street Campus" }, 
                new Campus { Id = MissionvaleId, UnivarsityId = NMUId, CampusCode = "9D", Name = "Missionvale Campus" }, 
                new Campus { Id = NorthId, UnivarsityId = NMUId, CampusCode = "9E", Name = "North Campus" }, 
                new Campus { Id = SouthId, UnivarsityId = NMUId, CampusCode = "9F", Name = "South Campus" }, 
                new Campus { Id = OceanSciencesId, UnivarsityId = NMUId, CampusCode = "9G", Name = "Ocean Sciences Campus" },

                // Univarsity of Pretoria
                new Campus { Id = HatfieldId, UnivarsityId = UPId, CampusCode = "10A", Name = "Hatfield Campus" }, 
                new Campus { Id = OnderstepoortId, UnivarsityId = UPId, CampusCode = "10B", Name = "Onderstepoort Campus" }, 
                new Campus { Id = GroenkloofId, UnivarsityId = UPId, CampusCode = "10C", Name = "Groenkloof Campus" }, 
                new Campus { Id = PrinshofId, UnivarsityId = UPId, CampusCode = "10D", Name = "Prinshof Campus" }, 
                new Campus { Id = HillcrestId, UnivarsityId = UPId, CampusCode = "10E", Name = "Hillcrest Campus" },
                new Campus { Id = MamelodiId, UnivarsityId = UPId, CampusCode = "10E", Name = "Mamelodi Campus" },

                // Tshwane Univarsity of Technology
                new Campus { Id = PretoriaMainId, UnivarsityId = TUTId, CampusCode = "11A", Name = "Pretoria Main Campus" }, 
                new Campus { Id = SoshanguveNorthId, UnivarsityId = TUTId, CampusCode = "11B", Name = "Soshanguve North Campus" }, 
                new Campus { Id = SoshanguveSouthId, UnivarsityId = TUTId, CampusCode = "11C", Name = "Soshanguve South Campus" },
                new Campus { Id = ArcadiaId, UnivarsityId = TUTId, CampusCode = "11D", Name = "Arcadia Campus" },
                new Campus { Id = ArtsId, UnivarsityId = TUTId, CampusCode = "11E", Name = "Arts Campus" },
                new Campus { Id = Ga-rankuwaId, UnivarsityId = TUTId, CampusCode = "11F", Name = "Ga-rankuwa Campus" },
                new Campus { Id = EmalahleniId, UnivarsityId = TUTId, CampusCode = "11G", Name = "Emalahleni Campus" },
                new Campus { Id = MbombelaId, UnivarsityId = TUTId, CampusCode = "11H", Name = "Mbombela Campus" },
                new Campus { Id = PolokwaneId, UnivarsityId = TUTId, CampusCode = "11I", Name = "Polokwane Campus" },

                // Vaal Univarsity of Technology
                new Campus { Id = VUTMainId, UniversityId = VUTId, CampusCode = "12", Name = "Vaal Univarsity of Technology" },

                // Durban Univarsity of Technology
                new Campus { Id = BrickfieldId, UnivarsityId = DUTId, CampusCode = "13A", Name = "Brickfield Campus" }, 
                new Campus { Id = CityId, UnivarsityId = DUTId, CampusCode = "13B", Name = "City Campus" }, 
                new Campus { Id = IndumisoId, UnivarsityId = DUTId, CampusCode = "13C", Name = "Indumiso Campus" }, 
                new Campus { Id = MLSultanId, UnivarsityId = DUTId, CampusCode = "13D", Name = "ML Sultan Campus" }, 
                new Campus { Id = RitsonId, UnivarsityId = DUTId, CampusCode = "13E", Name = "Ritson Campus" }, 
                new Campus { Id = RiversideId, UnivarsityId = DUTId, CampusCode = "13F", Name = "Riverside Campus" }, 
                new Campus { Id = SteveBikoId, UnivarsityId = DUTId, CampusCode = "13G", Name = "Steve Biko Campus" },

                // UNISA
                 new Campus { Id = UNISAId, UnivarsityId = UNISAId, CampusCode = "14", Name = "UNISA" },

                // Central Univarsity of Technology
                new Campus { Id = BloemId, UnivarsityId = CUTId, CampusCode = "15A", Name = "Bloemfontein Campus" },
                new Campus { Id = WelkomId, UnivarsityId = CUTId, CampusCode = "15B", Name = "Welkom Campus" },

                // Univarsity of Fort Hare
                new Campus { Id = AliceId, UnivarsityId = UFHId, CampusCode = "16A", Name = "Alice Campus" }, 
                new Campus { Id = EastLondonId, UnivarsityId = UFHId, CampusCode = "16B", Name = "East London Campus" }, 
                new Campus { Id = BishoId, UnivarsityId = UFHId, CampusCode = "16C", Name = "Bisho Campus" },

                // Univarsity of Free State
                 new Campus { Id = BloemfonteinId, UnivarsityId = UFSId, CampusCode = "17A", Name = "Bloemfontein Campus" }, 
                new Campus { Id = SouthId, UnivarsityId = UFSId, CampusCode = "17B", Name = "South Campus" }, 
                new Campus { Id = QwaqwaId, UnivarsityId = UFSId, CampusCode = "17C", Name = "Qwaqwa Campus" },

                // Univarsity of Limpopo
                new Campus { Id = ulMainId, UnivarsityId = ULId, CampusCode = "18", Name = "Univarsity of Limpopo" }

                // Univarsity of Venda
                new Campus { Id = univenId, UnivarsityId = UVId, CampusCode = "19", Name = "Univarsity of Venda" },

                // Univarsity of Mpumalanga
                new Campus { Id = MbombelaId, UnivarsityId = MUId, CampusCode = "20A", Name = " Mbombela Campus" },
                new Campus { Id = SiyabuswaId, UnivarsityId = MUId, CampusCode = "20B", Name = " Siyabuswa Campus" },

                // Rhodes University
                new Campus { Id = ruMainId, UnivarsityId = RUId, CampusCode = "21", Name = "Rhodes Univarsity" },

                // Sefako Makgatho Health Sciences Univarsity
                new Campus { Id = smuMainId, UnivarsityId = SMUId, CampusCode = "22A", Name = "SMU Main Campus" },

                // Sol Plaatje Univarsity
                new Campus { Id = NorthId, UnivarsityId = SPUId, CampusCode = "23A", Name = "North Campus" }, 
                new Campus { Id = SouthId, UnivarsityId = SPUId, CampusCode = "23B", Name = "South Campus" }, 
                new Campus { Id = CentralId, UnivarsityId = SPUId, CampusCode = "23C", Name = "Central Campus" },

                // Mangosuthu University of Technology
                new Campus { Id = MainId, UniversityId = MUTId, CampusCode = "24A", Name = "Main Campus" }, 
                new Campus { Id = NorthId, UniversityId = MUTId, CampusCode = "24B", Name = "North Campus" },

                // Walter Sisulu Univarsity
                new Campus { Id = MthathaId, UnivarsityId = WSUId, CampusCode = "25A", Name = "Mthatha Campus" }, 
                new Campus { Id = ButterworthId, UnivarsityId = WSUId, CampusCode = "25B", Name = "Butterworth Campus" }, 
                new Campus { Id = BuffaloCityId, UnivarsityId = WSUId, CampusCode = "25C", Name = "Buffalo City Campus" }, 
                new Campus { Id = KomaniId, UnivarsityId = WSUId, CampusCode = "25D", Name = "Komani Campus" }, 
                new Campus { Id = TygerbergId, UnivarsityId = UWCId, CampusCode = "25E", Name = "Tygerberg Campus" },

                // Univarsity of Western Cape
                new Campus { Id = TygerbergId, UnivarsityId = UWCId, CampusCode = "26A", Name = "Tygerberg Campus" },
                new Campus { Id = BellvilleId, UnivarsityId = UWCId, CampusCode = "26B", Name = "Bellville Campus" },
  
            );
        }
    }
}
