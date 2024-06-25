```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,307.8 ns** |      **94.66 ns** |     **5.19 ns** |     **1,304.6 ns** |     **1,313.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,481.2 ns |     251.73 ns |    13.80 ns |     1,471.9 ns |     1,497.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,713.6 ns |      61.06 ns |     3.35 ns |     1,710.5 ns |     1,717.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,690.7 ns |   1,104.18 ns |    60.52 ns |     2,655.0 ns |     2,760.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       232.5 ns |       4.02 ns |     0.22 ns |       232.3 ns |       232.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       289.0 ns |      17.53 ns |     0.96 ns |       288.4 ns |       290.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       497.4 ns |      50.81 ns |     2.79 ns |       494.2 ns |       499.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,602.3 ns** |  **17,946.45 ns** |   **983.71 ns** | **1,545,466.6 ns** | **1,547,185.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,299.1 ns |   1,170.78 ns |    64.17 ns |   614,257.9 ns |   614,373.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   658,290.0 ns | 108,942.81 ns | 5,971.52 ns |   654,751.2 ns |   665,184.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,258.6 ns |  22,767.73 ns | 1,247.98 ns | 1,373,203.6 ns | 1,375,636.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,423.3 ns |  37,909.65 ns | 2,077.96 ns |   162,158.5 ns |   165,821.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,609.1 ns |   3,578.79 ns |   196.17 ns |    91,383.5 ns |    91,738.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,306.9 ns |   3,473.35 ns |   190.39 ns |    65,091.6 ns |    65,453.0 ns |      - |      40 B |
