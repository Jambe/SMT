﻿using ESI.NET;
using System.Net;
using System;

namespace SMT.EVEData
{
    public class ESIHelpers
    {
        public static bool ValidateESICall<T>(EsiResponse<T> esiR)
        {
            if (esiR.StatusCode == HttpStatusCode.OK || esiR.StatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }


            Console.WriteLine("ESI Error : " + esiR.Message );
            return false;
        }
    }
}