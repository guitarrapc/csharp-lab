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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,330.6 ns** |    **365.79 ns** |    **20.05 ns** |     **1,317.5 ns** |     **1,353.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,475.5 ns |     47.27 ns |     2.59 ns |     1,473.8 ns |     1,478.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,740.9 ns |    347.96 ns |    19.07 ns |     1,720.0 ns |     1,757.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,691.4 ns |    135.34 ns |     7.42 ns |     2,685.7 ns |     2,699.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       206.5 ns |     68.77 ns |     3.77 ns |       204.0 ns |       210.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       293.3 ns |     46.80 ns |     2.57 ns |       291.8 ns |       296.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       498.4 ns |    465.87 ns |    25.54 ns |       482.1 ns |       527.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,795.8 ns** |  **3,760.16 ns** |   **206.11 ns** | **1,545,558.0 ns** | **1,545,921.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   613,985.8 ns |  1,672.36 ns |    91.67 ns |   613,880.6 ns |   614,048.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,485.3 ns | 25,159.73 ns | 1,379.09 ns |   654,657.6 ns |   657,077.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,438.9 ns | 56,551.02 ns | 3,099.75 ns | 1,372,266.0 ns | 1,377,988.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,616.2 ns |  8,269.04 ns |   453.25 ns |   162,257.5 ns |   163,125.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,521.8 ns |  2,479.05 ns |   135.88 ns |    91,421.4 ns |    91,676.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,160.5 ns |  8,045.12 ns |   440.98 ns |    64,899.4 ns |    65,669.6 ns |      - |      40 B |
