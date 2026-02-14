using Survey_Basket_API.Models;

namespace Survey_Basket_API.Service
{
    public interface IPollService
    {

    
        IEnumerable<Poll> Get();

      
       
        Poll GetById(int id);

      
        Poll Add(Poll poll);


        bool Update (int id , Poll poll);

        bool Delete(int id);

    }
}
