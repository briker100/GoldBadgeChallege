using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_8
{
    class ClaimRepo
    {
        Queue<ClaimRepo> Claim3 = new Queue<ClaimRepo>();
    }

    public Queue<ClaimRepo> GetClaimList()
    {
        return Claim3;
    }

    public void PrintList(Queue<ClaimRepo> list)
    {
        foreach (ClaimRepo item in list)
        {
            Console.WriteLine(item);
        }
    }

    public void AddClaim(ClaimRepo s)
    {
        ClaimRepo.Enqueue(s);
    }


}
