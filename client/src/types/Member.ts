export type Member = {
  id: string;
  dateOfBirth: string;
  imageUrl?: string;
  created: string;
  lastActive: string;
  displayName: string;
  gender: string;
  description?: string;
  city: string;
  country: string;
};

export type Photo = {
  id: number;
  url: string;
  publicId?: any;
  memberId: string;
};

export type EditableMember = {
  displayName: string;
  description?: string;
  city: string;
  country: string;
};
