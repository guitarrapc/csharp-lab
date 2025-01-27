```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,226.2 ns** |    **172.01 ns** |     **9.43 ns** |     **1,215.4 ns** |     **1,233.0 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,430.5 ns |     26.42 ns |     1.45 ns |     1,428.9 ns |     1,431.8 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,625.7 ns |     48.33 ns |     2.65 ns |     1,623.4 ns |     1,628.6 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,594.9 ns |     70.43 ns |     3.86 ns |     2,590.5 ns |     2,598.0 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       175.6 ns |     14.13 ns |     0.77 ns |       175.0 ns |       176.5 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       265.6 ns |     53.51 ns |     2.93 ns |       262.2 ns |       267.8 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       482.9 ns |     59.33 ns |     3.25 ns |       480.6 ns |       486.6 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,494.5 ns** |  **4,304.93 ns** |   **235.97 ns** | **1,554,262.8 ns** | **1,554,734.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,508.3 ns |  2,323.49 ns |   127.36 ns |   617,380.2 ns |   617,634.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   660,698.1 ns | 68,539.23 ns | 3,756.87 ns |   658,313.4 ns |   665,028.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,380,699.1 ns | 30,444.13 ns | 1,668.75 ns | 1,379,538.1 ns | 1,382,611.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,195.5 ns |  3,732.70 ns |   204.60 ns |   163,004.4 ns |   163,411.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,846.6 ns |    925.46 ns |    50.73 ns |    91,788.3 ns |    91,880.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,309.3 ns |  6,772.85 ns |   371.24 ns |    32,880.6 ns |    33,524.4 ns |      - |      40 B |
