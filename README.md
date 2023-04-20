# Armstrong Fake Generator Tool

Armstrong Generator -- маленькая утилита для генерации фейковых данных, которая
поможет нам при разработке WEB-клиента системы [ARMStrong](https://github.com/digital-armstrong)

- Имитирует опрос измерительных каналов;
- Сохраненяет результаты "измерений" в базу данных.

> ARMStrong Fake Geneerator является частью [ARMStrong](https://github.com/owlscatcher/Armstrong) и на время разработки выделен в отдельный репозиторий.

## Первый запуск

Для удобства приложение было обёрнуто в Docker, для его первого запуска контейнер требуется собрать:

```bash
docker build -t armstronggen .

docker run -d --privileged --restart unless-stopped armstronggen
```

Далее добавить образ в compose и запускаться после старта базы данных.
