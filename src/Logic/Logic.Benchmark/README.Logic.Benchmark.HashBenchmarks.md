```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,360.3 ns** |     **71.60 ns** |     **3.92 ns** |     **1,357.6 ns** |     **1,364.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,472.3 ns |    282.46 ns |    15.48 ns |     1,461.9 ns |     1,490.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,725.4 ns |    532.87 ns |    29.21 ns |     1,706.8 ns |     1,759.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,699.2 ns |    343.71 ns |    18.84 ns |     2,684.5 ns |     2,720.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.6 ns |      5.40 ns |     0.30 ns |       202.2 ns |       202.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       295.4 ns |    133.26 ns |     7.30 ns |       287.7 ns |       302.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       495.2 ns |     20.63 ns |     1.13 ns |       494.2 ns |       496.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,806.2 ns** |  **9,428.22 ns** |   **516.79 ns** | **1,545,406.8 ns** | **1,546,389.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,778.4 ns |  4,232.15 ns |   231.98 ns |   614,559.3 ns |   615,021.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,375.3 ns | 11,365.53 ns |   622.98 ns |   654,935.0 ns |   656,088.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,375,431.9 ns | 46,617.92 ns | 2,555.29 ns | 1,372,547.8 ns | 1,377,413.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,464.6 ns |  5,223.51 ns |   286.32 ns |   162,284.8 ns |   162,794.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,458.8 ns |  3,192.32 ns |   174.98 ns |    91,353.1 ns |    91,660.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,575.2 ns |  5,506.21 ns |   301.81 ns |    65,291.8 ns |    65,892.6 ns |      - |      40 B |
