# Diretorios

Tudo está em `/srv/apps`

O Filesystem Hierarchy Standard (FHS) do Linux define /srv como diretório para dados de serviços oferecidos pelo sistema. É exatamente o caso de aplicações self-hosted.

```bash
/srv/
├── apps/                    # Compose files e configuração de cada aplicação
│   ├── traefik/
│   │   ├── docker-compose.yml
│   │   └── config/
│   ├── portainer/
│   │   └── docker-compose.yml
│   ├── uptime-kuma/
│   │   └── docker-compose.yml
│   └── rustdesk/
│       └── docker-compose.yml
│
├── data/                    # Dados persistentes (volumes)
│   ├── traefik/
│   ├── portainer/
│   ├── uptime-kuma/
│   └── rustdesk/
│
├── logs/                    # Logs de aplicações (quando não vão para Docker)
│   └── traefik/
│
├── backups/                 # Backups locais antes de enviar para offsite
│   └── ...

```