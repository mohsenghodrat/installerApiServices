using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class RepairTicket
    {
        public long Id { get; set; }
        public string NoyeService { get; set; }
        public DateTime CreatedDateTime { get; set; }

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

        [DefaultValue(0)]
        public string CcqTx { get; set; }
        [DefaultValue(0)]
        public string CcqRx { get; set; }
        [DefaultValue(0)]
        public string SignalTx { get; set; }
        [DefaultValue(0)]
        public string SignalRx { get; set; }

        public bool NasbmahalJoghrafiyaye { get; set; }
        public bool NasbVaAmozeshehTShark { get; set; }
        public bool TahvilKartKarbar { get; set; }
        public bool AgahiyehKarbarAzMoshkelat { get; set; }
        public bool DaryafteEtelateKarbar { get; set; }
        public bool CheckKardanNamkarbaroVaRamzObor { get; set; }



        public bool DownloadTestSoraat { get; set; }
        public string BwTestTx { get; set; }
        public string BwTestRx { get; set; }
        public string TestSorat { get; set; }
        public bool CheckKardanLanAntenDarErtebatBaRadio { get; set; }
        public bool EtminanAzKhoshkBodanKabl { get; set; }
        public bool TesteAdaptor { get; set; }

        public string NahveyeAshnayeBaSherkat { get; set; }
        public string Tozehat { get; set; }
        public string TakhfifBeRiyal { get; set; }
        public string MablaghBeRiyal { get; set; }
        public string TozihatA { get; set; }
        public string HazinehBeRiyal { get; set; }
        public string TozihabB { get; set; }
    }
}
