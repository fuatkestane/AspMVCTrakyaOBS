﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi_MVC.Repositories
{
    public interface IBaseRepository : IDisposable { }

    public class BaseRepository : IBaseRepository
    {
        protected OBSContext _veritabani = new OBSContext();
        protected UyelikRepository _uyelik;

        public BaseRepository(bool uyelikAlinsinMi = true)
        {
            if (uyelikAlinsinMi)
                if (_uyelik == null)
                    _uyelik = new UyelikRepository();
        }

        public void Dispose()
        {
            _veritabani.Dispose();
        }
    }
}
