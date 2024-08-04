```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,308.9 ns** |    **152.73 ns** |     **8.37 ns** |     **1,300.0 ns** |     **1,316.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,475.1 ns |    179.06 ns |     9.81 ns |     1,467.8 ns |     1,486.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,702.1 ns |    374.53 ns |    20.53 ns |     1,687.2 ns |     1,725.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,660.3 ns |     23.20 ns |     1.27 ns |     2,658.8 ns |     2,661.3 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.9 ns |     15.23 ns |     0.83 ns |       201.1 ns |       202.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.1 ns |     21.61 ns |     1.18 ns |       285.3 ns |       287.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       502.5 ns |     32.62 ns |     1.79 ns |       501.2 ns |       504.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,899.4 ns** |  **3,999.46 ns** |   **219.22 ns** | **1,545,733.0 ns** | **1,546,147.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,475.3 ns |  4,321.33 ns |   236.87 ns |   614,286.8 ns |   614,741.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,222.0 ns | 19,279.90 ns | 1,056.80 ns |   655,287.1 ns |   657,368.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,621.0 ns | 37,616.50 ns | 2,061.89 ns | 1,372,555.0 ns | 1,376,678.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,427.6 ns |  4,487.48 ns |   245.97 ns |   162,267.3 ns |   162,710.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,576.7 ns |  2,818.03 ns |   154.47 ns |    91,480.8 ns |    91,754.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,474.4 ns | 12,867.14 ns |   705.29 ns |    64,976.6 ns |    66,281.5 ns |      - |      40 B |
