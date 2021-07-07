using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    interface ICRUD<DataType, IdType>
    {
        //C
        DataType Create(DataType dataType);

        //R
        DataType FindById(IdType idType);
        List<DataType> FindAll();

        //U
        DataType Update(DataType dataType);

        //D
        bool Delete(DataType dataType);
    }
}
