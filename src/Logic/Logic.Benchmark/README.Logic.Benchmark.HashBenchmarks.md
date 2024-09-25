```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,241.3 ns** |     **35.28 ns** |     **1.93 ns** |     **1,240.2 ns** |     **1,243.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,364.8 ns |    166.19 ns |     9.11 ns |     1,354.3 ns |     1,370.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,599.3 ns |     49.81 ns |     2.73 ns |     1,597.3 ns |     1,602.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,546.7 ns |    396.80 ns |    21.75 ns |     2,521.7 ns |     2,561.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       205.4 ns |     15.25 ns |     0.84 ns |       204.5 ns |       206.2 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.7 ns |     47.35 ns |     2.60 ns |       284.6 ns |       289.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       491.7 ns |     29.38 ns |     1.61 ns |       489.9 ns |       493.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,059.0 ns** |  **3,994.23 ns** |   **218.94 ns** | **1,553,807.9 ns** | **1,554,209.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,649.6 ns |    754.91 ns |    41.38 ns |   617,606.0 ns |   617,688.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   658,721.8 ns |  5,918.58 ns |   324.42 ns |   658,485.7 ns |   659,091.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,385,162.3 ns | 97,744.92 ns | 5,357.73 ns | 1,380,114.8 ns | 1,390,784.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,457.3 ns |  8,248.35 ns |   452.12 ns |   163,183.8 ns |   163,979.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,024.5 ns |  5,038.47 ns |   276.18 ns |    91,843.7 ns |    92,342.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,689.6 ns |  3,157.21 ns |   173.06 ns |    65,578.2 ns |    65,889.0 ns |      - |      40 B |
