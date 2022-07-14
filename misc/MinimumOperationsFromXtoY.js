input = lines[0].split(' ')
a = parseInt(input[0])
b = parseInt(input[1])
c = 0
while(b > a)
{
    if(b % 2 != 0)
    {
        b+=1;
    }
    else{
        b/=2;
    }
    c++;
}
c = c + (a-b);
console.log(c)