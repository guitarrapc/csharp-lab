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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,310.8 ns** |     **81.34 ns** |     **4.46 ns** |     **1,307.5 ns** |     **1,315.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,473.1 ns |    268.87 ns |    14.74 ns |     1,462.6 ns |     1,490.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,712.2 ns |     83.66 ns |     4.59 ns |     1,708.6 ns |     1,717.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,687.6 ns |    794.75 ns |    43.56 ns |     2,658.2 ns |     2,737.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.5 ns |     30.88 ns |     1.69 ns |       200.7 ns |       204.0 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.8 ns |     10.57 ns |     0.58 ns |       285.2 ns |       286.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       493.3 ns |      7.95 ns |     0.44 ns |       492.8 ns |       493.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,950.3 ns** |  **3,695.73 ns** |   **202.58 ns** | **1,545,763.6 ns** | **1,546,165.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,420.5 ns |  2,310.42 ns |   126.64 ns |   614,327.3 ns |   614,564.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,704.0 ns | 16,570.64 ns |   908.29 ns |   654,939.0 ns |   656,707.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,375,468.1 ns | 56,680.66 ns | 3,106.86 ns | 1,372,638.0 ns | 1,378,792.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,264.1 ns |    337.47 ns |    18.50 ns |   162,243.4 ns |   162,279.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,443.2 ns |    601.71 ns |    32.98 ns |    92,413.4 ns |    92,478.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,500.1 ns |  2,236.64 ns |   122.60 ns |    65,376.5 ns |    65,621.6 ns |      - |      40 B |
