using DataLayer.DBLayer;
using DataLayer.Repositories;
using GoogleMaps.LocationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UI.Controllers.Services
{
    public class CoordinatesController : ApiController
    {
        IGenericRepository<Rent> _repository;

        public CoordinatesController(IGenericRepository<Rent> repository)
        {
            _repository = repository;
        }

        public void GetCoordinates(int id)
        {
            Rent rent = _repository.Get(id);
            string address = rent.RentAddress;
            var locationService = new GoogleLocationService();
            MapPoint point = locationService.GetLatLongFromAddress(address);
            rent.Latitude = System.Convert.ToDecimal(point.Latitude);
            rent.Longitude = System.Convert.ToDecimal(point.Longitude);
            _repository.AddOrUpdate(rent);           
        }

    }
}
