using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class RepairTicket
    {
        public RepairTicket()
        {
        }
        [Key]
        public long Id { get; set; }
        [Required]
        public string TicketId { get; set; }
        public string NoyeService { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedRepairTicketDateTime { get; set; }

        [DefaultValue(" ")]
        public bool NahveyeBastanANtenBaBasyFelizi { get; set; }
        [DefaultValue(" ")]
        public bool MakanNasbAntenDarFilmMojodAst { get; set; }
        [DefaultValue(" ")]
        public bool AmozeshSHarjKardan { get; set; }
        [DefaultValue(" ")]
        public bool AyaAntenRoyeSolehAst { get; set; }
        [DefaultValue(" ")]
        public bool TestGerftanSignal { get; set; }

        [DefaultValue(" ")]
        public string CcqTx { get; set; }
        [DefaultValue(" ")]
        public string CcqRx { get; set; }
        [DefaultValue(" ")]
        public string SignalTx { get; set; }
        [DefaultValue(" ")]
        public string SignalRx { get; set; }

        public bool NasbmahalJoghrafiyaye { get; set; }
        public bool NasbVaAmozeshehTShark { get; set; }
        public bool TahvilKartKarbar { get; set; }
        public bool AgahiyehKarbarAzMoshkelat { get; set; }
        public bool DaryafteEtelateKarbar { get; set; }
        public bool CheckKardanNamkarbaroVaRamzObor { get; set; }



        public bool DownloadTestSoraat { get; set; }
        [DefaultValue(" ")]
        public string BwTestTx { get; set; }
        [DefaultValue(" ")]
        public string BwTestRx { get; set; }
        [DefaultValue(" ")]
        public string TestSorat { get; set; }
        public bool CheckKardanLanAntenDarErtebatBaRadio { get; set; }
        public bool EtminanAzKhoshkBodanKabl { get; set; }
        public bool TesteAdaptor { get; set; }
        [DefaultValue(" ")]
        public string NahveyeAshnayeBaSherkat { get; set; }
        [DefaultValue(" ")]
        public string Tozehat { get; set; }
        [DefaultValue(" ")]
        public string TakhfifBeRiyal { get; set; }
        [DefaultValue(" ")]
        public string MablaghBeRiyal { get; set; }
        [DefaultValue(" ")]
        public string TozihatA { get; set; }
        [DefaultValue(" ")]
        public string HazinehBeRiyal { get; set; }
        [DefaultValue(" ")]
        public string TozihabB { get; set; }
    }
}
