using API.DTO;
using API.Domain;
using System;
using System.Collections.Generic;

namespace API.Application
{
    public interface IPizzaService
    {
        void AddComment(Guid id, Comment comment);

        PizzaDetailDTO FindById(Guid id);

        ICollection<PizzaSummaryDTO> FindAll();

        PizzaDetailDTO Create(CreatePizzaDTO dto);
    }
}