```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,317.9 ns** |      **98.74 ns** |     **5.41 ns** |     **1,313.0 ns** |     **1,323.7 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,461.0 ns |     103.85 ns |     5.69 ns |     1,454.5 ns |     1,465.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,687.6 ns |     187.80 ns |    10.29 ns |     1,681.5 ns |     1,699.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,656.3 ns |     152.03 ns |     8.33 ns |     2,648.3 ns |     2,664.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       196.0 ns |       6.25 ns |     0.34 ns |       195.6 ns |       196.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.5 ns |      17.09 ns |     0.94 ns |       284.8 ns |       286.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       497.0 ns |      80.34 ns |     4.40 ns |       491.9 ns |       499.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,537,434.1 ns** |  **84,508.90 ns** | **4,632.22 ns** | **1,534,726.9 ns** | **1,542,782.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,158.9 ns |     685.15 ns |    37.56 ns |   614,135.3 ns |   614,202.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   653,197.8 ns |  24,641.65 ns | 1,350.69 ns |   652,052.5 ns |   654,687.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,376,915.5 ns | 127,670.91 ns | 6,998.07 ns | 1,371,902.9 ns | 1,384,910.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,359.6 ns |   4,035.45 ns |   221.20 ns |   162,207.9 ns |   162,613.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,071.0 ns |   4,019.06 ns |   220.30 ns |    91,918.7 ns |    92,323.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,343.5 ns |   1,312.40 ns |    71.94 ns |    65,264.4 ns |    65,404.9 ns |      - |      40 B |
