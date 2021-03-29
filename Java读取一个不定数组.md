```Java
Scanner sc = new Scanner(System.in);
String s=sc.nextLine();//读入一行string
String[] c=s.split("\\s+");//根据空格进行分割
int[] arr=new int[c.length];
for(int i=0;i<c.length;i++) 
{	 
    arr[i]=Integer.parseInt(c[i]);//将string转为int型
}
```