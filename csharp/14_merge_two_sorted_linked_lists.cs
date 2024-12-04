using System;

namespace csharp
{
    public class Program
    {
        public static void Main()
        {
            var result = new SinglyLinkedListNode(0);
            var current = result;
            
            while(head1 != null && head2 != null) {
                if (head1.data < head2.data) {
                    current.next = head1;
                    head1 = head1.next;
                } else {
                    current.next = head2;
                    head2 = head2.next;
                }
                current = current.next;
            }
            
            if (head1 != null) {
                current.next = head1;
            } else if (head2 != null) {
                current.next = head2;
            }
            
            return result.next;
        }
    }
}