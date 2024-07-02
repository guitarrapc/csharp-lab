```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,321.5 ns** |     **47.14 ns** |     **2.58 ns** |     **1,319.4 ns** |     **1,324.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,469.0 ns |    287.94 ns |    15.78 ns |     1,458.2 ns |     1,487.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,718.5 ns |    448.39 ns |    24.58 ns |     1,704.0 ns |     1,746.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,692.8 ns |     79.71 ns |     4.37 ns |     2,688.2 ns |     2,696.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       203.8 ns |     26.55 ns |     1.46 ns |       202.9 ns |       205.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       288.3 ns |     52.58 ns |     2.88 ns |       285.3 ns |       291.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       478.2 ns |     24.68 ns |     1.35 ns |       476.7 ns |       479.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,687.7 ns** |  **5,137.02 ns** |   **281.58 ns** | **1,545,379.1 ns** | **1,545,930.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,083.5 ns |    751.72 ns |    41.20 ns |   614,046.5 ns |   614,127.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,049.5 ns | 20,394.48 ns | 1,117.89 ns |   655,018.9 ns |   657,237.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,672.5 ns | 20,219.42 ns | 1,108.29 ns | 1,371,571.9 ns | 1,373,788.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,204.0 ns |    576.16 ns |    31.58 ns |   162,169.0 ns |   162,230.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,409.0 ns |  1,688.19 ns |    92.54 ns |    91,336.9 ns |    91,513.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,124.3 ns |    597.72 ns |    32.76 ns |    65,090.1 ns |    65,155.4 ns |      - |      40 B |
