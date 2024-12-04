using System;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            if(head1 == null){
                return head2;
            }
            if(head2 == null){
                return head1;
            }
            if (head1.data > head2.data){
                
                head2.next =  mergeLists(head1, head2.next);
                return head2;
            }
            else{
                head1.next =  mergeLists(head1.next, head2);
                return head1;
            }
        }
    }
}