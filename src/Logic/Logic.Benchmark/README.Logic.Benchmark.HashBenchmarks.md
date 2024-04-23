```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,320.0 ns** |     **186.34 ns** |     **10.21 ns** |     **1,311.1 ns** |     **1,331.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,480.6 ns |     267.86 ns |     14.68 ns |     1,469.2 ns |     1,497.2 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,745.4 ns |     918.33 ns |     50.34 ns |     1,706.0 ns |     1,802.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,647.6 ns |     207.16 ns |     11.36 ns |     2,638.9 ns |     2,660.4 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.2 ns |      31.85 ns |      1.75 ns |       199.1 ns |       202.2 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.0 ns |      16.14 ns |      0.88 ns |       285.5 ns |       287.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       516.3 ns |      31.41 ns |      1.72 ns |       514.4 ns |       517.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,708.2 ns** |  **19,876.00 ns** |  **1,089.47 ns** | **1,544,940.7 ns** | **1,546,955.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,309.4 ns |   2,593.28 ns |    142.15 ns |   614,147.4 ns |   614,413.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,594.4 ns |  12,297.66 ns |    674.08 ns |   654,954.3 ns |   656,298.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,384,158.7 ns | 334,415.25 ns | 18,330.43 ns | 1,372,244.9 ns | 1,405,266.5 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,114.8 ns |     709.34 ns |     38.88 ns |   162,072.3 ns |   162,148.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,399.3 ns |   1,470.17 ns |     80.59 ns |    91,328.9 ns |    91,487.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,377.9 ns |   4,081.36 ns |    223.71 ns |    65,193.0 ns |    65,626.6 ns |      - |      40 B |
