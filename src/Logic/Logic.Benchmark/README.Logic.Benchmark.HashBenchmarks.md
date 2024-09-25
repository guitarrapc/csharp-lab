```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,267.7 ns** |    **137.76 ns** |   **7.55 ns** |     **1,260.6 ns** |     **1,275.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,478.3 ns |    423.92 ns |  23.24 ns |     1,462.6 ns |     1,505.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,613.8 ns |    189.26 ns |  10.37 ns |     1,606.6 ns |     1,625.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,592.2 ns |     52.00 ns |   2.85 ns |     2,589.0 ns |     2,594.3 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       207.3 ns |     45.59 ns |   2.50 ns |       205.5 ns |       210.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       291.1 ns |     18.83 ns |   1.03 ns |       290.3 ns |       292.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       499.8 ns |     32.40 ns |   1.78 ns |       498.0 ns |       501.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,047.0 ns** |  **2,947.67 ns** | **161.57 ns** | **1,553,864.1 ns** | **1,554,170.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,773.9 ns |  3,188.88 ns | 174.79 ns |   617,613.9 ns |   617,960.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   660,660.0 ns | 13,173.32 ns | 722.07 ns |   660,015.2 ns |   661,440.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,381,558.5 ns | 16,854.93 ns | 923.88 ns | 1,380,660.0 ns | 1,382,505.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,563.9 ns | 11,543.39 ns | 632.73 ns |   163,064.6 ns |   164,275.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,017.6 ns |  1,125.69 ns |  61.70 ns |    91,954.0 ns |    92,077.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    66,002.6 ns |  5,396.20 ns | 295.78 ns |    65,782.5 ns |    66,338.9 ns |      - |      40 B |
