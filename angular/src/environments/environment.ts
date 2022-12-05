import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AbpEcommerce Admin',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:5000/',
    redirectUri: baseUrl,
    clientId: 'AbpEcommerce_Admin',
    responseType: 'code',
    scope: 'AbpEcommerce.Admin offline_access',
    requireHttps: true

  },
  apis: {
    default: {
      url: 'https://localhost:5001',
      rootNamespace: 'AbpEcommerce.Admin',
    },
  },
} as Environment;
