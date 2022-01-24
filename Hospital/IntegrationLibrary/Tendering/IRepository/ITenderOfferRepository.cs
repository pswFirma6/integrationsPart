﻿using IntegrationLibrary.Pharmacy.IRepository;
using IntegrationLibrary.Tendering.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationLibrary.Tendering.IRepository
{
    public interface ITenderOfferRepository : IRepo<TenderOffer>
    {
        List<TenderOffer> GetTenderOffers();
    }
}
