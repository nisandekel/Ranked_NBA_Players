using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ranked_NBA_Players.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NBA : ControllerBase
    {

        [HttpGet]
        public async Task<string> GetRankedPlayers(string year)
        {

        }

    }
}
