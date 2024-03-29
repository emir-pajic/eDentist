﻿using AutoMapper;
using eDentist.Model;
using eDentist.Model.Request;
using eDentist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eDentist.WebAPI.Service
{
    public class AppointmentsService : CRUDService<MAppointments, AppointmentsSearchRequest, Appointments, AppointmentsUpsertRequest, AppointmentsUpsertRequest>
    {
        private readonly eDentistContext _context;
        private readonly IMapper _mapper;
        public AppointmentsService(eDentistContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override async Task<MAppointments> Insert(AppointmentsUpsertRequest request)
        {
            var entity = _mapper.Map<Appointments>(request);
            var day = _context.Days.Find(GetWeekDayId((int)entity.Date.DayOfWeek));
            entity.Day = day;
            entity.DayId = day.DayId;
            await _context.Appointments.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<MAppointments>(entity);

        }

        public override async Task<bool> Delete(int ID)
        {
            var entity = await _context.Appointments.
                Include(i => i.Examinations).
                FirstOrDefaultAsync(i => i.AppointmentId == ID);

            _context.Appointments.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        private int GetWeekDayId(int dayOfWeek)
        {
            if (dayOfWeek == 0)
            {
                return 7;
            }
            return dayOfWeek;
        }

    }
}
