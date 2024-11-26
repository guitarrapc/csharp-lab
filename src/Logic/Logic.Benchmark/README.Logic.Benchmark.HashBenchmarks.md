```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,320.4 ns** |      **96.57 ns** |      **5.29 ns** |     **1,315.1 ns** |     **1,325.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,443.4 ns |     114.73 ns |      6.29 ns |     1,438.2 ns |     1,450.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,703.1 ns |      66.76 ns |      3.66 ns |     1,699.1 ns |     1,706.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,688.9 ns |      87.40 ns |      4.79 ns |     2,683.5 ns |     2,692.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       197.8 ns |       8.81 ns |      0.48 ns |       197.4 ns |       198.4 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.9 ns |       2.87 ns |      0.16 ns |       286.8 ns |       287.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       511.3 ns |      28.00 ns |      1.53 ns |       510.1 ns |       513.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,664.6 ns** |   **1,545.65 ns** |     **84.72 ns** | **1,545,586.8 ns** | **1,545,754.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,288.1 ns |   4,783.40 ns |    262.19 ns |   614,087.1 ns |   614,584.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,830.2 ns |  15,222.18 ns |    834.38 ns |   655,884.0 ns |   657,460.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,378,739.6 ns | 201,510.59 ns | 11,045.48 ns | 1,372,228.7 ns | 1,391,492.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,269.0 ns |   1,859.55 ns |    101.93 ns |   162,209.8 ns |   162,386.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,433.3 ns |   1,673.92 ns |     91.75 ns |    91,365.9 ns |    91,537.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,249.2 ns |     728.22 ns |     39.92 ns |    65,213.7 ns |    65,292.4 ns |      - |      40 B |
