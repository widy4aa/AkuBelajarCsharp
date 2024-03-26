using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HildaDiagramLaptop
{
    internal class laptop
    {
        string merek_laptop, warna, processor_name, kondisi;
        int memory_size, storage_size;

        public laptop()
        {

        }

        public static void TurnOn()
        {

        }

        public static void TurnOff()
        {

        }
    }
    class laptop_gaming : laptop
    {
        bool rgb, overclocking, makro;

        public laptop_gaming() : base()
        {

        }

        public static void turnOnRgb()
        {

        }
        public static void turnOffRgb()
        {

        }

        public static void turnOnOc()
        {

        }

        public static void turnOffOc()
        {

        }

    }

    class laptop_gaming_comfortable : laptop_gaming
    {
        bool Ergonomic_Design;
        public laptop_gaming_comfortable() : base()
        {

        }

        public void detachable_screen()
        {

        }
    }

    class laptop_gaming_hardcore : laptop_gaming
    {
        bool overclock_charging;
        public laptop_gaming_hardcore() : base()
        {

        }

        public void TurnOnAdvancedOverclock()
        {

        }
    }
    class laptop_office : laptop
    {
        string office_app;
        bool fingerpint;

        public laptop_office() : base()
        {

        }
        
        public void addFingerprint()
        {

        }
    }
    class laptop_student : laptop_office
    {
        public string Sister,google_parrent;

        public laptop_student() : base()
        {

        }

        public void SisterAbsensi()
        {

        }
    }

    class laptop_bussiness : laptop_office
    {
       string WalletApp,WindowsPro;

        public laptop_bussiness() : base()
        {

        }

        public void addNewWallet()
        {

        }
    }
    class laptop_studio : laptop
    {
        public string StudioApp;
        bool AudioCard;
        
        public laptop_studio () : base()
        {

        }
        public void addNewAudioCard()
        {

        }
    }

    class laptop_graphic : laptop_studio
    {
        bool stylusPen;

        public laptop_graphic() : base()
        {

        }
        public void ConectStyluspen()
        {

        }
    }
    class laptop_VideoEditing : laptop_studio
    {
        bool mullticore_rendering;

        public laptop_VideoEditing() : base()
        {

        }
        public void EnableMutiCoreRendsering()
        {

        }
    }
}
