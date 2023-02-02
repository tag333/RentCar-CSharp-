
namespace CarRent
{
    public interface IWriter
    {
        void FillHeader();

        void FillBody();

        void FillFooter();

        Raport GetRaport();
    }
}

