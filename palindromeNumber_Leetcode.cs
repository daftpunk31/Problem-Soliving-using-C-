public class Solution {
    public bool IsPalindrome(int x) {
        int reversed = 0, num = x;
        if(x<0){
            return false;
        }
        else{
            while(num!=0){
                reversed = (reversed * 10) + (num % 10);
                num = (num / 10);
            }
            if(reversed == x){
                return true;
            }
            else{
                return false;
            }
        }
    }
}