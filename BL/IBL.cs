
using BE;
using DAL;

namespace BL
{
    public interface IBL
    {  //add functions
        void addtester(Tester x);
        void addtrainee(Trainee x);
        void addtest(Test x);

        void updatest(Test x);
    }
}
