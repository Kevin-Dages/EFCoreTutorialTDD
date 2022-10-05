using EFCoreTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorial
{

        public class SongRepository : Repository<Song>
        {
            public SongRepository(MusicContext context) : base(context)
            {
                // This ensures our base constructor gets run.
            }
        }
    }

