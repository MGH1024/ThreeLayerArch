using Repositories;
using Core.Entities;
using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ProvinceService
    {
        private readonly ProvinceRepository _provinceRepository;
        public ProvinceService()
        {
            _provinceRepository = new ProvinceRepository();
        }

        public void CreateProvince(ProvinceDto provinceDto)
        {
            var province = new Province();
            province.Name = provinceDto.Name;
            _provinceRepository.CreateProvince(province);
        }

        public IEnumerable<ProvinceDto> GetAll()
        {
            return _provinceRepository.GetAll().Select(a => new ProvinceDto
            {
                Id = a.Id,
                Name = a.Name,
            });
        }
    }
}
