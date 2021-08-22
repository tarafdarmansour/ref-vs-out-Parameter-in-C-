# Difference between Ref and Out keywords in C#

I think it is simple but important. 

|  No. | Key | ref keyword	| out keyword |
|------| ---:| ------------:| -----------:|
|  1    |  Purpose   |  ref keyword is used when a called method has to update the passed parameter. |    out keyword is used when a called method has to update multiple parameter passed. |
|  2    |  Direction   |    ref keyword is used to pass data in bi-directional way. |out keyword is used to get data in uni-directional way. |
|  3    |  Initialization (in parent method)  |Before passing a variable as ref, it is required to be initialized otherwise compiler will throw error.|No need to initialize variable if out keyword is used.|
|  4    |Initialization (in called method) |In called method, it is not required to initialize the parameter passed as ref.| In called method, it is required to initialize the parameter passed as out.|

These information provided from [tutorialspoint](https://www.tutorialspoint.com/difference-between-out-and-ref-keyword-in-chash) and  [geeksforgeeks](https://www.geeksforgeeks.org/difference-between-ref-and-out-keywords-in-c-sharp/)

