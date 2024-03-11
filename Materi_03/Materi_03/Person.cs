using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materi_03
{
    internal class Person
    {
        String Nama, JenisKelamin, Alamat, Hobby;
        void SetNama(String Nama)
        {
            this.Nama = Nama;
        }
        String getNama()
        {
            return this.Nama;
        }

    }
}
