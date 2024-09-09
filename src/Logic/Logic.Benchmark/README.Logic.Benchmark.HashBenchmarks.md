```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,368.3 ns** |    **333.66 ns** |    **18.29 ns** |     **1,356.9 ns** |     **1,389.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,443.9 ns |    159.97 ns |     8.77 ns |     1,438.5 ns |     1,454.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,694.3 ns |     71.39 ns |     3.91 ns |     1,691.0 ns |     1,698.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,670.6 ns |    108.88 ns |     5.97 ns |     2,666.0 ns |     2,677.4 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       208.2 ns |     17.86 ns |     0.98 ns |       207.2 ns |       209.2 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       295.8 ns |     61.14 ns |     3.35 ns |       293.8 ns |       299.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       489.1 ns |      9.59 ns |     0.53 ns |       488.7 ns |       489.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,569.8 ns** |  **8,270.88 ns** |   **453.35 ns** | **1,545,209.0 ns** | **1,546,078.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,272.7 ns |  2,281.28 ns |   125.04 ns |   614,129.2 ns |   614,358.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,200.5 ns |  1,764.89 ns |    96.74 ns |   655,089.6 ns |   655,267.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,139.9 ns | 62,150.41 ns | 3,406.67 ns | 1,371,858.2 ns | 1,378,055.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,343.4 ns |  5,114.19 ns |   280.33 ns |   162,171.4 ns |   162,666.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,479.8 ns |    740.39 ns |    40.58 ns |    91,448.6 ns |    91,525.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,280.7 ns |  1,336.76 ns |    73.27 ns |    65,222.9 ns |    65,363.2 ns |      - |      40 B |
