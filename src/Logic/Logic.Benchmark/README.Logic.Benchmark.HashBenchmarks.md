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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,242.5 ns** |    **278.25 ns** |    **15.25 ns** |     **1,232.4 ns** |     **1,260.1 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,364.6 ns |     56.10 ns |     3.08 ns |     1,361.4 ns |     1,367.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,638.4 ns |    245.89 ns |    13.48 ns |     1,628.8 ns |     1,653.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,586.7 ns |    127.72 ns |     7.00 ns |     2,581.1 ns |     2,594.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.9 ns |     29.57 ns |     1.62 ns |       198.2 ns |       201.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.1 ns |     16.26 ns |     0.89 ns |       284.5 ns |       286.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       516.1 ns |     53.97 ns |     2.96 ns |       513.2 ns |       519.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,999.9 ns** |    **415.47 ns** |    **22.77 ns** | **1,553,985.5 ns** | **1,554,026.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,656.4 ns |  2,237.68 ns |   122.65 ns |   617,521.2 ns |   617,760.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   658,858.1 ns |  8,036.12 ns |   440.49 ns |   658,591.6 ns |   659,366.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,381,778.3 ns | 57,805.71 ns | 3,168.53 ns | 1,379,562.6 ns | 1,385,407.5 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,318.4 ns |  3,808.18 ns |   208.74 ns |   163,183.6 ns |   163,558.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,945.8 ns |    265.05 ns |    14.53 ns |    91,929.0 ns |    91,955.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,675.3 ns |    618.43 ns |    33.90 ns |    65,639.5 ns |    65,707.0 ns |      - |      40 B |
