```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,225.2 ns** |     **105.20 ns** |     **5.77 ns** |     **1,219.6 ns** |     **1,231.1 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,407.5 ns |      75.83 ns |     4.16 ns |     1,402.8 ns |     1,410.6 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,644.5 ns |      68.38 ns |     3.75 ns |     1,640.2 ns |     1,646.8 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,593.4 ns |     645.40 ns |    35.38 ns |     2,570.9 ns |     2,634.2 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       183.8 ns |      58.06 ns |     3.18 ns |       181.9 ns |       187.5 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       286.1 ns |      85.09 ns |     4.66 ns |       283.4 ns |       291.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       456.5 ns |       4.32 ns |     0.24 ns |       456.2 ns |       456.7 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,313.3 ns |     115.47 ns |     6.33 ns |     1,308.8 ns |     1,320.5 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,515.7 ns |     144.12 ns |     7.90 ns |     1,510.4 ns |     1,524.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,619.5 ns |      85.65 ns |     4.69 ns |     1,614.1 ns |     1,622.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,534.8 ns |     481.53 ns |    26.39 ns |     2,519.5 ns |     2,565.3 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       176.0 ns |      10.01 ns |     0.55 ns |       175.4 ns |       176.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       260.7 ns |     189.04 ns |    10.36 ns |       254.0 ns |       272.6 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       472.7 ns |      41.68 ns |     2.28 ns |       470.9 ns |       475.3 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,361.4 ns** |   **4,470.78 ns** |   **245.06 ns** | **1,553,090.7 ns** | **1,553,568.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,615.5 ns |   4,187.42 ns |   229.53 ns |   617,368.0 ns |   617,821.3 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,993.9 ns |  23,141.30 ns | 1,268.45 ns |   658,540.7 ns |   660,879.4 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,386,008.3 ns | 159,912.77 ns | 8,765.36 ns | 1,380,895.9 ns | 1,396,129.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,657.4 ns |   7,309.36 ns |   400.65 ns |   163,207.4 ns |   163,975.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,040.5 ns |     745.35 ns |    40.85 ns |    91,994.2 ns |    92,071.4 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,661.9 ns |   1,704.09 ns |    93.41 ns |    65,570.3 ns |    65,757.0 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,555,818.7 ns |  71,192.84 ns | 3,902.32 ns | 1,553,440.3 ns | 1,560,322.3 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   618,072.6 ns |   2,353.41 ns |   129.00 ns |   617,961.4 ns |   618,214.0 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,771.1 ns |  27,688.42 ns | 1,517.70 ns |   658,467.6 ns |   661,437.3 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,386,057.8 ns | 156,999.07 ns | 8,605.65 ns | 1,380,968.6 ns | 1,395,993.8 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,372.9 ns |   6,260.24 ns |   343.15 ns |   163,155.6 ns |   163,768.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,093.9 ns |   5,534.40 ns |   303.36 ns |    91,894.4 ns |    92,443.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,262.5 ns |   6,408.40 ns |   351.27 ns |    33,857.3 ns |    34,480.3 ns |      - |      40 B |
