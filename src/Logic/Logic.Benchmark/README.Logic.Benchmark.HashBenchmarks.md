```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,240.9 ns** |     **101.59 ns** |     **5.57 ns** |     **1,236.2 ns** |     **1,247.1 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,407.8 ns |     103.57 ns |     5.68 ns |     1,401.4 ns |     1,412.4 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,654.8 ns |     273.53 ns |    14.99 ns |     1,640.8 ns |     1,670.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,576.5 ns |     158.68 ns |     8.70 ns |     2,566.7 ns |     2,583.2 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       183.8 ns |      15.92 ns |     0.87 ns |       183.0 ns |       184.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       266.2 ns |      26.96 ns |     1.48 ns |       264.6 ns |       267.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       471.3 ns |      20.54 ns |     1.13 ns |       470.4 ns |       472.6 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,246.9 ns |     166.66 ns |     9.14 ns |     1,238.9 ns |     1,256.8 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,418.6 ns |     184.64 ns |    10.12 ns |     1,407.9 ns |     1,428.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,623.3 ns |      89.94 ns |     4.93 ns |     1,617.8 ns |     1,627.2 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,549.9 ns |      65.55 ns |     3.59 ns |     2,546.2 ns |     2,553.4 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       176.1 ns |      30.84 ns |     1.69 ns |       174.6 ns |       177.9 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       260.1 ns |      37.78 ns |     2.07 ns |       258.7 ns |       262.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       463.7 ns |      56.02 ns |     3.07 ns |       460.7 ns |       466.8 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,459.2 ns** |  **12,535.22 ns** |   **687.10 ns** | **1,553,755.7 ns** | **1,555,128.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,541.6 ns |   2,572.92 ns |   141.03 ns |   617,390.6 ns |   617,669.9 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,362.3 ns |  26,051.72 ns | 1,427.98 ns |   658,420.7 ns |   661,005.4 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,379,627.7 ns |   7,818.57 ns |   428.56 ns | 1,379,171.8 ns | 1,380,022.3 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,230.7 ns |   4,715.05 ns |   258.45 ns |   163,022.0 ns |   163,519.8 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,651.4 ns |  24,560.04 ns | 1,346.22 ns |    91,850.5 ns |    94,205.7 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,597.3 ns |     307.84 ns |    16.87 ns |    65,579.8 ns |    65,613.5 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,770.0 ns |   3,789.98 ns |   207.74 ns | 1,553,615.1 ns | 1,554,006.0 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,370.2 ns |   1,039.73 ns |    56.99 ns |   617,318.5 ns |   617,431.3 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,996.8 ns |  24,507.59 ns | 1,343.34 ns |   658,462.6 ns |   660,962.1 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,385,300.9 ns | 155,128.91 ns | 8,503.14 ns | 1,379,999.0 ns | 1,395,108.7 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,672.2 ns |  16,195.63 ns |   887.74 ns |   163,124.2 ns |   164,696.4 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,355.0 ns |   7,661.64 ns |   419.96 ns |    91,883.9 ns |    92,690.1 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,158.5 ns |   3,575.95 ns |   196.01 ns |    33,932.2 ns |    34,274.4 ns |      - |      40 B |
